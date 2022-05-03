using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using CSI250Lab2.Models;
using System.Linq;

namespace CSI250Lab2.Controllers
{

    public class AlbumsController : Controller
    {
        private List<Album> newAlbumList;
        public AlbumsController(IAlbumList newAlbumList){
            this.newAlbumList = newAlbumList.GetAlbums();
        }
        [HttpGet]
        public IActionResult Index(decimal price, int sort){
            System.Console.WriteLine(sort);
            System.Console.WriteLine(price);
            if(sort > 0){
                if(sort == 1){
                    newAlbumList.Sort((x, y) => x.Id.CompareTo(y.Id));
                }else if(sort == 2){
                    newAlbumList.Sort((x, y) => x.Price.CompareTo(y.Price));
                }else if(sort == 3){
                    newAlbumList.Sort((x, y) => x.Artist.CompareTo(y.Artist));
                }
                else if(sort == 4){
                    newAlbumList.Sort((x, y) => x.Title.CompareTo(y.Title));
                }
                else if(sort == 5){
                    newAlbumList.Sort((x, y) => x.Genre.CompareTo(y.Genre));
                }
            }
            IEnumerable<decimal> prices = newAlbumList.Select(a => a.Price).Distinct();
            IEnumerable<SelectListItem> selectListPrices = prices.Select(
                price => new SelectListItem
                {
                    Text = price.ToString(),
                    Value = price.ToString()
                });
            //Pass this to my view in the ViewBag - ViewData
            ViewBag.SelectListPrices = selectListPrices.OrderBy(x => x.Value);

            if(Object.Equals(price, default(decimal))){
                return View(newAlbumList);
            }else{
                List<Album> newList = new List<Album>();
                foreach(Album album in newAlbumList){
                    if(album.Price == price){
                        newList.Add(album);
                    }
                }

                return View(newList);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id){
            //Get the album from the list by ID
            Album album = newAlbumList.SingleOrDefault(x => x.Id == id);
            if( album == null)
            {
                return NotFound();
            }
            //pass the album as a model to the view
            return View(album);  
        }
        [HttpPost]
        public IActionResult Edit(Album model)
        {
            //The information that the user put in the form will be inside
            //of the model that came back from the view
            //Get the album we want to change from the "Database"
            System.Console.WriteLine(ModelState.IsValid);
            if(!ModelState.IsValid){
                return RedirectToAction("Index");
            }
            Album album = newAlbumList.SingleOrDefault(x => x.Id == model.Id);
            //update the info in the album
            album.Title = model.Title;
            album.Genre = model.Genre;
            album.Price = model.Price;
            album.Artist = model.Artist;
            //Show the index view which will have updated data.
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Album newAlbum){
            newAlbumList.Add(newAlbum);
            return RedirectToAction("Index");
        }
        public IActionResult Search(string term){
            string[] searchterms = term.Split(" ");
            searchterms = searchterms.Where(x => !string.IsNullOrEmpty(x.Trim())).ToArray();
            // foreach(string test in searchterms)
            //     {
            //         System.Console.WriteLine(test);
            //     }
            List<SearchResultModel> results = new List<SearchResultModel>();

            foreach(Album album in newAlbumList){
                SearchResultModel newSearchResult = new SearchResultModel();
                double weight = 0;
                double multi = 1;
                foreach(string substring in searchterms){
                    multi = 1;
                    switch(substring) {
                        case "the": multi = .5; break;
                        case "of": multi = .7; break;
                        case "is": multi = .5; break;
                    }
                    string newRegex = "("+substring.Replace("\"", "")+")";
                    // System.Console.WriteLine(newRegex);
                    // System.Console.WriteLine(Regex.Matches(testAlbum.Title, newRegex, RegexOptions.IgnoreCase).Count);
                    if(Regex.Matches($"{album.Id}", "\\b("+substring.Replace("\"", "")+")\\b", RegexOptions.IgnoreCase).Count > 0){
                        weight = (weight + 100) * multi;
                    }
                    if(Regex.Matches(album.Artist, newRegex, RegexOptions.IgnoreCase).Count > 0){
                        weight = (weight + 15) * multi;
                    }
                    if(Regex.Matches(album.Title, newRegex, RegexOptions.IgnoreCase).Count > 0){
                        weight = (weight + 10) * multi;
                    }
                    if(Regex.Matches(album.Genre, newRegex, RegexOptions.IgnoreCase).Count > 0){
                        weight = (weight + 5) * multi;
                    }
                    if(Regex.Match($"{album.Price}", newRegex, RegexOptions.IgnoreCase).Success){
                        weight = (weight + 5) * (multi * 
                        (1/(Regex.Match($"{album.Price}", newRegex, RegexOptions.IgnoreCase).Index + 1)));
                    }

                }
                if(weight > 0){
                    newSearchResult.result = album;
                    newSearchResult.weight = weight;
                    results.Add(newSearchResult);
                }
            }
            if(results.Count == 0){
                return NotFound("Nothing found!");
            }
            results.Sort((x, y) => y.weight.CompareTo(x.weight));
            // System.Console.WriteLine(results.Count);
           return View(results);
        }
        public IActionResult SearchByName(string AlbumName){
            AlbumName = AlbumName.Replace("\"", "");
            System.Console.WriteLine(AlbumName);
            foreach (Album album in newAlbumList){
                System.Console.WriteLine(album.Title);
                if(album.Title == AlbumName){
                    return Json(album);
                }
            }
            return NotFound("nothing found!");
        }
        public IActionResult SearchByPrice(decimal price){
            List<Album> newList = new List<Album>();
            foreach (Album album in newAlbumList){
                if(album.Price == price){
                    newList.Add(album);
                }
            }
            if(newList.Count > 0){
                return Json(newList);
            }else{
                return NotFound("nothing found!");
            }
        }
        public IActionResult OrderByPrice(){
            newAlbumList.Sort((x, y) => x.Price.CompareTo(y.Price));
            return Json(newAlbumList);
        }
    }

}