#light "off"
module GenericSort

let rec sorted = (fun ( l  :  'a Prims.list ) ( key  :  'a  ->  Prims.int ) -> (match (l) with
| [] -> begin
true
end
| (uu___)::[] -> begin
true
end
| (x)::(y)::xs -> begin
(((key x) <= (key y)) && (sorted ((y)::xs) key))
end))


let test_sorted2 = (fun ( uu___  :  unit ) ( key  :  'a  ->  Prims.int ) -> [])


type permutation =
unit


type permutation_2 =
unit




