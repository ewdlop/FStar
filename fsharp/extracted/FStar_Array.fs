#light "off"
module FStar_Array

type 'a array =
'a FStar_Seq_Base.seq FStar_ST.ref


type ('a, 'h) contains =
('a FStar_Seq_Base.seq, unit, 'h, obj) FStar_Monotonic_Heap.contains


type ('a, 'h) unused_in =
('a FStar_Seq_Base.seq, unit, obj, 'h) FStar_Monotonic_Heap.unused_in


let op_At_Bar = (fun ( s1  :  'a array ) ( s2  :  'a array ) -> (

let s1' = (FStar_Ref.op_Bang s1)
in (

let s2' = (FStar_Ref.op_Bang s2)
in (FStar_ST.alloc (FStar_Seq_Base.append s1' s2')))))


type create_post =
unit


let of_seq = (fun ( s  :  'a FStar_Seq_Base.seq ) -> (FStar_ST.alloc s))


let to_seq = (fun ( s  :  'a array ) -> (FStar_Ref.op_Bang s))


let of_list = (fun ( l  :  'a Prims.list ) -> (of_seq (FStar_Seq_Base.seq_of_list l)))


let create = (fun ( n  :  Prims.nat ) ( init  :  'a ) -> (FStar_ST.alloc (FStar_Seq_Base.create n init)))


let index = (fun ( x  :  'a array ) ( n  :  Prims.nat ) -> (

let s = (to_seq x)
in (FStar_Seq_Base.index s n)))


let upd = (fun ( x  :  'a array ) ( n  :  Prims.nat ) ( v  :  'a ) -> (

let s = (FStar_Ref.op_Bang x)
in (

let s' = (FStar_Seq_Base.upd s n v)
in (FStar_Ref.op_Colon_Equals x s'))))


let length = (fun ( x  :  'a array ) -> (

let s = (FStar_Ref.op_Bang x)
in (FStar_Seq_Base.length s)))


let op = (fun ( f  :  'a FStar_Seq_Base.seq  ->  'a FStar_Seq_Base.seq ) ( x  :  'a array ) -> (

let s = (FStar_Ref.op_Bang x)
in (

let s' = (f s)
in (FStar_Ref.op_Colon_Equals x s'))))


let swap = (fun ( x  :  'a array ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) -> (

let tmpi = (index x i)
in (

let tmpj = (index x j)
in ((upd x j tmpi);
(upd x i tmpj);
))))


let rec copy_aux = (fun ( s  :  'a array ) ( cpy  :  'a array ) ( ctr  :  Prims.nat ) -> (

let uu___ = (

let uu___1 = (length cpy)
in (uu___1 - ctr))
in (match (uu___) with
| uu___1 when (uu___1 = (Prims.parse_int "0")) -> begin
()
end
| uu___1 -> begin
((

let uu___3 = (index s ctr)
in (upd cpy ctr uu___3));
(copy_aux s cpy (ctr + (Prims.parse_int "1")));
)
end)))


let copy = (fun ( s  :  'a array ) -> (

let cpy = (

let uu___ = (length s)
in (

let uu___1 = (index s (Prims.parse_int "0"))
in (create uu___ uu___1)))
in ((copy_aux s cpy (Prims.parse_int "0"));
cpy;
)))


let rec blit_aux = (fun ( s  :  'a array ) ( s_idx  :  Prims.nat ) ( t  :  'a array ) ( t_idx  :  Prims.nat ) ( len  :  Prims.nat ) ( ctr  :  Prims.nat ) -> (match ((len - ctr)) with
| uu___ when (uu___ = (Prims.parse_int "0")) -> begin
()
end
| uu___ -> begin
((

let uu___2 = (index s (s_idx + ctr))
in (upd t (t_idx + ctr) uu___2));
(blit_aux s s_idx t t_idx len (ctr + (Prims.parse_int "1")));
)
end))


let blit = (fun ( s  :  'a array ) ( s_idx  :  Prims.nat ) ( t  :  'a array ) ( t_idx  :  Prims.nat ) ( len  :  Prims.nat ) -> (blit_aux s s_idx t t_idx len (Prims.parse_int "0")))


let sub = (fun ( s  :  'a array ) ( idx  :  Prims.nat ) ( len  :  Prims.nat ) -> (

let h0 = (FStar_ST.get ())
in (

let t = (

let uu___ = (index s (Prims.parse_int "0"))
in (create len uu___))
in ((blit s idx t (Prims.parse_int "0") len);
(

let h1 = (FStar_ST.get ())
in t);
))))




