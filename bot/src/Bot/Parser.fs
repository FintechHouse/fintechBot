namespace fintechHouse.Bot

module Parser = 

  open System
  open Domain
  open Utility

  let parseTweet (str: string) = 
    match str with 
      | TryParseQueryYear qy -> Ok(qy)
      | TryParseQuery q -> Ok(q)
      | _ -> Error "not a correct query"