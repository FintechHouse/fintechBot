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
      | [| s; sn; TryParseIntoYear Int32.TryParse yy |] -> 
          Some(
            {
              Sender = s
              Symbol = sn
              FromDate = DateTime(yy, 01, 01)
              ToDate = DateTime(yy, 12, 31)
            })
      | _ -> None

