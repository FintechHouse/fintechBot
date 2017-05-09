namespace fintechHouse.Bot


module Utility =
  open System
  open System.Globalization

  let (|Eq|_|) expect myval =    // check equality on any type supporting equality
    if expect = myval then Some ()
    else None

  let (|Val|_|) =   // generally find a value in a map providing the key
    Map.tryFind

   // wrap all the .Net Tryparse function, or all the function
   // that return a tuple (bool, K) and return an option (Some<k> or None)
  let (|TryParseAP|_|) f str =
    match f str with
      | true, rs -> Some rs
      | false, _ -> None

  let (|TryParseExactAP|_|) f (format: String) v =
    match f (v, format, CultureInfo.InvariantCulture, DateTimeStyles.None) with
      | true, rs -> Some rs
      | false, _ -> None


let aa = DateTime.TryParseExact (" ", "format", CultureInfo.InvariantCulture, DateTimeStyles.None) 

match "1/1/2000" with
| TryParseAP DateTime.TryParse x -> Some(x)
| _ -> None


match "1/1/2000" with
  | TryParseExactAP DateTime.TryParseExact format) x -> Some ()
  | _ -> None


