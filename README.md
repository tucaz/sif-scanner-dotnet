# Sif Scanner DotNet

A Simple library to parse SIF files in F#

# Usage

SIF files are text files comprised of pairs usually grouped into parts or other identifies like the one below:

```
PN=A180-HWB
PD=Product description 180
CT2=
P1=2028.00
P2=1984.00
WT=54.00
GC=A1901
VO=19.50
G0=180CYLIND
G1=180FRAME
PN=A180-HWBFC
PD=Other product description 180
CT2=
P1=2128.00
P2=2083.00
WT=54.00
GC=A1901
VO=19.50
G0=180CYLIND
G1=180FRAME
PN=A180-HWS
PD=Yet another product description 180
CT2=
P1=2028.00
P2=1984.00
WT=54.00
GC=A1901
VO=19.50
G0=180CYLIND
G1=180FRAMESL
```

The library breaks into into sub groups to be used individually by giving it a pattern

```f#
open SifScanner
open System.IO
open System.Text.RegularExpressions

let data = File.ReadAllLines "pathToSif.file" |> Array.toList
let matchPartNumber line = Regex.IsMatch(line, "^PN=")
let parts = breakBy data matchPartNumber

printfn "%A" parts
```
