namespace fintechHouse.Bot

module Parser = 

  open Domain

  let parseTweet (str: string) = 
    let x = str.Split([|' '|])
    match x.Length with 
      | 2 -> 
          Ok (
            {
              Sender = x.[0]
              Symbol = x.[1]
            })
      | _ -> Error "not a correct query"

