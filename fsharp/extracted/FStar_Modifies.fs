#light "off"
module FStar_Modifies
type loc_aux =
| LocBuffer of unit * obj FStar_Buffer.buffer


let uu___is_LocBuffer : loc_aux  ->  Prims.bool = (fun ( projectee  :  loc_aux ) -> true)


let __proj__LocBuffer__item__b : loc_aux  ->  obj FStar_Buffer.buffer = (fun ( projectee  :  loc_aux ) -> (match (projectee) with
| LocBuffer (t, b) -> begin
b
end))


type loc_aux_in_addr =
obj


type aloc =
loc_aux


type loc_aux_includes_buffer =
obj


type loc_aux_includes =
obj


type loc_aux_disjoint_buffer =
obj


type loc_aux_disjoint =
obj


type loc_aux_preserved =
obj


type loc =
unit





















