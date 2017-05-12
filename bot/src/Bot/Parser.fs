namespace fintechHouse.Bot

module Parser = 

  open System
  open Domain
  open Utility

  let parseTweet (str: string) = 
    match str with 
      | TryParseQuery q -> Ok(q)
      | _ -> Error "not a correct query"