module fintechHouse.bot.Tests

open System
open Xunit
open fintechHouse.bot

[<Fact>]
let ``My test`` () =
  let actual = Say.hello "Stefano"
  Assert.Equal("Hello Stefano", actual)
