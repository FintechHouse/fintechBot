namespace fintechHouse.Bot

module Domain = 

  open System
  open Utility

  type Query = {
    Sender : string
    Symbol : string
    FromDate: DateTime
    ToDate: DateTime
  }

  type QueryWithYear = {
    Sender : string
    Symbol : string
    Year: int
  }

  let (|TryParseQuery|_|) (q: string) =
    let ar = q.Split([|' '|])
    match ar with
      | [| s; sn; TryParseAP DateTime.TryParse fd; TryParseAP DateTime.TryParse td; |] -> 
          Some(
            {
              Sender = s
              Symbol = sn
              FromDate = fd
              ToDate = td
            })
      | _ -> None

  
  let (|TryParseQueryYear|_|) (q: string) =
    let ar = q.Split([|' '|])
    match ar with
      | [| s; sn; fd; td; |] -> 
          Some(
            {
              Sender = s
              Symbol = sn
              Year = 2017
            })
      | _ -> None

