#light "off"
module FStar_List_Tot_Properties

type 'a llist =
'a Prims.list


let rec rev' = (fun ( xs  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
[]
end
| (hd)::tl -> begin
(FStar_List_Tot_Base.op_At (rev' tl) ((hd)::[]))
end))


let rev'T = (fun ( uu___  :  unit ) -> rev')


let rec sorted = (fun ( f  :  'a  ->  'a  ->  Prims.bool ) ( uu___  :  'a Prims.list ) -> (match (uu___) with
| [] -> begin
true
end
| (uu___1)::[] -> begin
true
end
| (x)::(y)::tl -> begin
((f x y) && (sorted f ((y)::tl)))
end))


type total_order =
unit




