#light "off"
module IntSort

let rec sorted : Prims.int Prims.list  ->  Prims.bool = (fun ( l  :  Prims.int Prims.list ) -> (match (l) with
| [] -> begin
true
end
| (uu___)::[] -> begin
true
end
| (x)::(y)::xs -> begin
((x <= y) && (sorted ((y)::xs)))
end))


let test_sorted2 : unit  ->  Prims.int Prims.list = (fun ( uu___  :  unit ) -> [])


type permutation =
unit


type permutation_2 =
unit




