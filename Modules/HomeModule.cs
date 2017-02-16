using Nancy;
using System.Collections.Generic;
using ScrabbleGame.Objects;


namespace ScrabbleGame
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/result"] = _ => {
                string userInput = Request.Form["word"];
                Scrabble newScrabble = new Scrabble(userInput);
                return View["index.cshtml", newScrabble];
            };
        }
    }
}
