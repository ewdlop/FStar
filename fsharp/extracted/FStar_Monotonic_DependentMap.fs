#light "off"
module FStar_Monotonic_DependentMap

type 'b opt =
'b FStar_Pervasives_Native.option


type ('a, 'b) partial_dependent_map =
('a, 'b opt) FStar_DependentMap.t


let empty_partial_dependent_map = (fun ( uu___  :  unit ) -> (FStar_DependentMap.create (fun ( x  :  'a ) -> FStar_Pervasives_Native.None)))


type ('a, 'b) map =
('a, 'b) Prims.dtuple2 Prims.list


let empty = (fun ( uu___  :  unit ) -> [])


let rec sel = (fun ( r  :  ('a, 'b) map ) ( x  :  'a ) -> (match (r) with
| [] -> begin
FStar_Pervasives_Native.None
end
| (Prims.Mkdtuple2 (x', y))::tl -> begin
(match ((Prims.op_Equality x x')) with
| true -> begin
FStar_Pervasives_Native.Some (y)
end
| uu___ -> begin
(sel tl x)
end)
end))


let upd = (fun ( r  :  ('a, 'b) map ) ( x  :  'a ) ( v  :  'b ) -> (Prims.Mkdtuple2 (x, v))::r)


type ('a, 'b) imap =
('a, 'b) map


type grows' =
unit



type ('a, 'b) t =
(('a, 'b) imap, unit) FStar_HyperStack_ST.m_rref


type defined =
unit


type fresh =
unit


type contains =
unit


let alloc = (fun ( r  :  unit ) ( uu___  :  unit ) -> (FStar_HyperStack_ST.ralloc () []))


let extend = (fun ( r  :  unit ) ( t1  :  ('a, 'b) t ) ( x  :  'a ) ( y  :  'b ) -> ((FStar_HyperStack_ST.recall t1);
(

let cur = (FStar_HyperStack_ST.op_Bang t1)
in ((FStar_HyperStack_ST.op_Colon_Equals t1 (upd cur x y));
(FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce t1) ());
));
))


let lookup = (fun ( r  :  unit ) ( t1  :  ('a, 'b) t ) ( x  :  'a ) -> (

let m = (FStar_HyperStack_ST.op_Bang t1)
in (

let y = (sel m x)
in (match (y) with
| FStar_Pervasives_Native.None -> begin
y
end
| FStar_Pervasives_Native.Some (b1) -> begin
((FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce t1) ());
y;
)
end))))


type forall_t =
unit


let f_opt = (fun ( f  :  'a  ->  'b  ->  'c ) ( x  :  'a ) ( y  :  'b FStar_Pervasives_Native.option ) -> (match (y) with
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.None
end
| FStar_Pervasives_Native.Some (y1) -> begin
FStar_Pervasives_Native.Some ((f x y1))
end))


let rec mmap_f = (fun ( m  :  ('a, 'b) map ) ( f  :  'a  ->  'b  ->  'c ) -> (match (m) with
| [] -> begin
[]
end
| (Prims.Mkdtuple2 (x, y))::tl -> begin
(Prims.Mkdtuple2 (x, (f x y)))::(mmap_f tl f)
end))


let map_f = (fun ( r  :  unit ) ( r'  :  unit ) ( t1  :  ('a, 'b) t ) ( f  :  'a  ->  'b  ->  'c ) -> (

let m = (FStar_HyperStack_ST.op_Bang t1)
in (FStar_HyperStack_ST.ralloc () (mmap_f m f))))




