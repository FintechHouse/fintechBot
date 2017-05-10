namespace fintechHouse.Bot

module Domain = 

  open System

  type Query = {
    Sender : string
    Symbol : string
    FromDate: DateTime
    ToDate: DateTime
  }