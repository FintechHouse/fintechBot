module ParserTests

open System
open Xunit
open fintechHouse.Bot
open Domain

[<Fact>]
let ``test Parser with two strings input`` () =
  let expected = {
    Sender = "Stefano"
    Symbol = "STF"
  }
  let actual = Parser.parseTweet "Stefano STF"
  match actual with 
    | Ok r -> Assert.Equal(expected, r)
    | Error _ -> Assert.True(false, "Error")


[<Fact>]
let ``test Parser with three strings input`` () =
  let expected = {
    Sender = "Stefano"
    Symbol = "STF"
  }
  let actual = Parser.parseTweet "Stefano STF WWW"
  match actual with 
    | Ok r -> Assert.True(false, "Error")
    | Error _ -> Assert.True(true, "Ok!")

