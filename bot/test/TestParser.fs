module ParserTests

open System
open Xunit
open fintechHouse.Bot
open Domain

[<Fact>]
let ``test Parser with two strings input should not work`` () =
  let expected = {
    Sender = "Stefano"
    Symbol = "STF"
    FromDate = DateTime.Now
    ToDate = DateTime.Now
  }
  let actual = Parser.parseTweet "Stefano STF"
  match actual with 
    | Ok r -> Assert.True(false, "This should fails, no query with only two symbols allowed")
    | Error _ -> Assert.True(true, "Correct! Query not allowed")


[<Fact>]
let ``test Parser with correct year`` () =
  let expected = {
    Sender = "Stefano"
    Symbol = "STF"
    FromDate = DateTime(2016, 01, 01)
    ToDate = DateTime(2016, 12, 31)
  }
  let actual = Parser.parseTweet "Stefano STF 2016"
  match actual with 
    | Ok r -> Assert.Equal(expected, r)
    | Error _ -> Assert.True(false, "Error")


[<Fact>]
let ``test Parser with three strings input`` () =
  let expected = {
    Sender = "Stefano"
    Symbol = "STF"
    FromDate = DateTime.Now
    ToDate = DateTime.Now
  }
  let actual = Parser.parseTweet "Stefano STF WWW"
  match actual with 
    | Ok r -> Assert.True(false, "Error")
    | Error _ -> Assert.True(true, "Ok!")

