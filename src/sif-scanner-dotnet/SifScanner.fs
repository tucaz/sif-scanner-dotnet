#if INTERACTIVE
#else
module SifScanner 
#endif

let breakBy lines pattern =
    let rec breakByRec lines pattern acc = 
        match lines with 
        | [] -> acc
        | head::tail ->
            match pattern head with
            | true ->
                let newGroup = [head]
                let newList = newGroup :: acc
                breakByRec tail pattern newList
            | false ->
                let lastGroup = List.head acc                
                let newGroup = head :: lastGroup;
                let newList = newGroup :: List.tail acc
                breakByRec tail pattern newList
    breakByRec lines pattern []