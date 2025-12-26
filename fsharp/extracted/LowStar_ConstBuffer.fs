#light "off"
module LowStar_ConstBuffer

type qbuf_cases =
obj


type q_preorder =
obj


type qbuf =
(unit, obj) Prims.dtuple2


type qbuf_pre =
obj


let qbuf_mbuf = (fun ( uu___  :  qbuf ) -> ((fun ( c  :  qbuf ) -> (Prims.unsafe_coerce (FStar_Pervasives.dsnd c))) uu___))



let as_qbuf = (fun ( c  :  'a const_buffer ) -> c)


type ('a, 'h) live =
('a, obj, obj, 'h, obj) LowStar_Monotonic_Buffer.live


let of_buffer = (fun ( b  :  'a LowStar_Buffer.buffer ) -> Prims.Mkdtuple2 ((), (Prims.unsafe_coerce b)))


let of_ibuffer = (fun ( b  :  'a LowStar_ImmutableBuffer.ibuffer ) -> Prims.Mkdtuple2 ((), (Prims.unsafe_coerce b)))


let of_qbuf = (fun ( q  :  unit ) ( b  :  ('uuuuu, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) -> Prims.Mkdtuple2 ((), (Prims.unsafe_coerce b)))


let null1 = (fun ( uu___  :  unit ) -> (of_buffer (LowStar_Monotonic_Buffer.mnull ())))


let is_null = (fun ( c  :  'a const_buffer ) -> (

let x = (qbuf_mbuf c)
in (LowStar_Monotonic_Buffer.is_null x)))


let index = (fun ( c  :  'a const_buffer ) ( i  :  FStar_UInt32.t ) -> (

let x = (qbuf_mbuf c)
in (LowStar_Monotonic_Buffer.index x i)))


type const_sub_buffer =
unit


let sub = (fun ( c  :  'a const_buffer ) ( i  :  FStar_UInt32.t ) ( len  :  unit ) -> (

let uu___ = c
in (match (uu___) with
| Prims.Mkdtuple2 (q, x) -> begin
(

let x1 = (Prims.unsafe_coerce x)
in (

let y = (LowStar_Monotonic_Buffer.msub x1 i ())
in Prims.Mkdtuple2 ((), (Prims.unsafe_coerce y))))
end)))


let cast = (fun ( c  :  'a const_buffer ) -> (qbuf_mbuf c))


let to_buffer = (fun ( uu___  :  'a const_buffer ) -> ((fun ( c  :  'a const_buffer ) -> (Prims.unsafe_coerce (qbuf_mbuf c))) uu___))


let to_ibuffer = (fun ( uu___  :  'a const_buffer ) -> ((fun ( c  :  'a const_buffer ) -> (Prims.unsafe_coerce (qbuf_mbuf c))) uu___))


let test : FStar_UInt32.t LowStar_Buffer.buffer  ->  FStar_UInt32.t LowStar_ImmutableBuffer.ibuffer  ->  FStar_UInt32.t = (fun ( x  :  FStar_UInt32.t LowStar_Buffer.buffer ) ( y  :  FStar_UInt32.t LowStar_ImmutableBuffer.ibuffer ) -> (

let c1 = (of_buffer x)
in (

let c2 = (of_ibuffer y)
in ((

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' x (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))));
(

let a = (index c1 (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))
in (

let a' = (index c2 (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))
in (

let c3 = (sub c2 (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))) ())
in (

let a'' = (index c3 (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))
in (FStar_UInt32.add (FStar_UInt32.add a a') a'')))));
))))




