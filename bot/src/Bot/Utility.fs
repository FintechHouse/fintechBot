namespace fintechHouse.Bot


module Utility =
  open System
  open System.Globalization

  let (|Eq|_|) expect myval =    // check equality on any type supporting equality
    if expect = myval then Some ()
    else None

  let (|Greater|_|) cmp myval =    // check equality on any type supporting equality
    if myval > cmp then Some (myval)
    else None

  let (|LessThan|_|) cmp myval =    // check equality on any type supporting equality
    if myval < cmp then Some (myval)
    else None

  let (|Val|_|) =   // generally find a value in a map providing the key
    Map.tryFind

   // wrap all the .Net Tryparse function, or all the function
   // that return a tuple (bool, K) and return an option (Some<k> or None)
  let (|TryParseAP|_|) f str =
    match f str with
      | true, rs -> Some rs
      | false, _ -> None

  
  let nextYear = DateTime.Now.Year + 1

  let (|IntToYear|_|) y = 
    match y with 
    | Greater 1970 yy & LessThan nextYear ay -> Some ay
    | _ -> None


  let(|TryParseIntoYear|_|) f y =
    match f y with 
    | true, IntToYear rs -> Some rs
    | _, _ -> None

  // let (|TryParseExactAP|_|) f format v =
  //   match f (v, format, CultureInfo.InvariantCulture, DateTimeStyles.None) with
  //     | true, rs -> Some rs
  //     | false, _ -> None


// let aa = DateTime.TryParseExact ("01/01/2000", "M/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None)  

// match "1/1/2000" with
// | TryParseAP DateTime.TryParse x -> Some(x)
// | _ -> None

