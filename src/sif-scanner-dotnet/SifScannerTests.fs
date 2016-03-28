#if INTERACTIVE
#else
module SifScannerTests
open SifScanner
#endif

open System.IO
open System.Text.RegularExpressions

let data = [
    "Name=John"; "Age=29"; "City=San Francisco";
    "Name=Jane"; "Age=28"; "City=New York";
    "Name=Mike"; "Age=35"; "City=Miami"
]

let matchName line = Regex.IsMatch(line, "^Name=")
let people = breakBy data matchName

printfn "%A" people