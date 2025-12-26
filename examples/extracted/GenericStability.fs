#light "off"
module GenericStability

let rec filter_eq = (fun ( x  :  Prims.int ) ( xs  :  'a Prims.list ) ( k  :  'a  ->  Prims.int ) -> (match (xs) with
| [] -> begin
[]
end
| (hd)::tl -> begin
(match ((Prims.op_Equality (k hd) x)) with
| true -> begin
(hd)::(filter_eq x tl k)
end
| uu___ -> begin
(filter_eq x tl k)
end)
end))


type stable =
unit




