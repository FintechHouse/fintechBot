namespace fintechHouse.Bot

module Parser = 

  open System
  open Domain
  open Utility

  let parseTweet (str: string) = 
    match str with 
      | TryParseQuery q -> Ok(q)
      | _ -> Error "not a correct query"


      //let x = str.Split([|' '|])
    //match x with 
      // ask the quotation for all the year
      // | [| snd; sy; TryParseIntoYear Int32.TryParse yy |] ->
      //     Ok (
      //       {
      //         Sender = x.[0]
      //         Symbol = x.[1]
      //         FromDate = DateTime(yy, 01, 01)
      //         ToDate = DateTime(yy, 12, 31)
      //       }) 
      // | [| snd; sy; TryParseAP DateTime.TryParse startD; TryParseAP DateTime.TryParse endD |] ->
      //     Ok (
      //       {
      //         Sender = x.[0]
      //         Symbol = x.[1]
      //         FromDate = startD
      //         ToDate = endD
      //       }) 

