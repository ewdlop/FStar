#light "off"
module LowStar_Lens

type get_t =
unit


type put_t =
unit


type get_put =
unit


type put_get =
unit


type put_put =
unit

type ('a, 'b) lens =
{get : unit; put : unit; lens_laws : unit}








type imem =
FStar_Monotonic_HyperStack.mem


type eloc =
unit


type get_reads_loc =
unit


type put_modifies_loc =
unit


type invariant_reads_loc =
unit


type 'b imem_lens =
(imem, 'b) lens

type ('a, 'b) hs_lens =
{footprint : unit; invariant : unit; x : 'a; snapshot : imem; l : 'b imem_lens}





let __proj__Mkhs_lens__item__x = (fun ( projectee  :  ('a, 'b) hs_lens ) -> (match (projectee) with
| {footprint = footprint; invariant = invariant; x = x; snapshot = snapshot; l = l} -> begin
x
end))


let __proj__Mkhs_lens__item__snapshot = (fun ( projectee  :  ('a, 'b) hs_lens ) -> (match (projectee) with
| {footprint = footprint; invariant = invariant; x = x; snapshot = snapshot; l = l} -> begin
snapshot
end))


let __proj__Mkhs_lens__item__l = (fun ( projectee  :  ('a, 'b) hs_lens ) -> (match (projectee) with
| {footprint = footprint; invariant = invariant; x = x; snapshot = snapshot; l = l} -> begin
l
end))


let snap = (fun ( l  :  ('a, 'b) hs_lens ) ( h  :  imem ) -> {footprint = (); invariant = (); x = l.x; snapshot = h; l = l.l})




type 'result with_snapshot =
imem  ->  'result


let for_n = (fun ( lens1  :  ('a, 'b) hs_lens ) ( n  :  Prims.nat ) ( inv1  :  unit ) ( f  :  Prims.nat  ->  unit ) -> (

let rec aux : Prims.nat  ->  unit = (fun ( i  :  Prims.nat ) -> (match ((Prims.op_Equality i n)) with
| true -> begin
()
end
| uu___ -> begin
((f i);
(aux (i + (Prims.parse_int "1")));
)
end))
in (aux (Prims.parse_int "0"))))




