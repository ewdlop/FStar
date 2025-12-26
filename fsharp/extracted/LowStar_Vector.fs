#light "off"
module LowStar_Vector

type uint32_t =
FStar_UInt32.t


let max_uint32 : uint32_t = (FStar_UInt32.uint_to_t ((Prims.parse_int "4294967295")))

type 'a vector_str =
| Vec of uint32_t * uint32_t * 'a LowStar_Buffer.buffer


let uu___is_Vec = (fun ( projectee  :  'a vector_str ) -> true)


let __proj__Vec__item__sz = (fun ( projectee  :  'a vector_str ) -> (match (projectee) with
| Vec (sz, cap, vs) -> begin
sz
end))


let __proj__Vec__item__cap = (fun ( projectee  :  'a vector_str ) -> (match (projectee) with
| Vec (sz, cap, vs) -> begin
cap
end))


let __proj__Vec__item__vs = (fun ( projectee  :  'a vector_str ) -> (match (projectee) with
| Vec (sz, cap, vs) -> begin
vs
end))


type 'a vector =
'a vector_str


let size_of = (fun ( vec  :  'a vector ) -> (match (vec) with
| Vec (sz, cap, vs) -> begin
sz
end))


let capacity_of = (fun ( vec  :  'a vector ) -> (match (vec) with
| Vec (sz, cap, vs) -> begin
cap
end))


let is_empty = (fun ( vec  :  'a vector ) -> (Prims.op_Equality (match (vec) with
| Vec (sz, cap, vs) -> begin
sz
end) (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))








let alloc_empty = (fun ( uu___  :  unit ) -> Vec ((FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (LowStar_Monotonic_Buffer.mnull ())))


let alloc_rid = (fun ( len  :  uint32_t ) ( v  :  'a ) ( rid  :  unit ) -> (

let uu___ = (LowStar_Monotonic_Buffer.mmalloc () v len)
in Vec (len, len, uu___)))


let alloc = (fun ( len  :  uint32_t ) ( v  :  'a ) -> (alloc_rid len v ()))


let alloc_reserve = (fun ( len  :  uint32_t ) ( ia  :  'a ) ( rid  :  unit ) -> (

let uu___ = (LowStar_Monotonic_Buffer.mmalloc () ia len)
in Vec ((FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), len, uu___)))


let alloc_by_buffer = (fun ( len  :  uint32_t ) ( buf  :  'a LowStar_Buffer.buffer ) -> Vec (len, len, buf))


let free = (fun ( vec  :  'a vector ) -> (LowStar_Monotonic_Buffer.free (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end)))


let index = (fun ( vec  :  'a vector ) ( i  :  uint32_t ) -> (LowStar_Monotonic_Buffer.index (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end) i))


let front = (fun ( vec  :  'a vector ) -> (LowStar_Monotonic_Buffer.index (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end) (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let back = (fun ( vec  :  'a vector ) -> (LowStar_Monotonic_Buffer.index (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end) (FStar_UInt32.sub (match (vec) with
| Vec (sz, cap, vs) -> begin
sz
end) (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))))))


let clear = (fun ( vec  :  'a vector ) -> Vec ((FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (match (vec) with
| Vec (sz, cap, vs) -> begin
cap
end), (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end)))


let assign = (fun ( vec  :  'a vector ) ( i  :  uint32_t ) ( v  :  'a ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((

let uu___1 = (LowStar_Monotonic_Buffer.msub (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end) i ())
in (

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' uu___1 (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) v)));
(

let hh1 = (FStar_HyperStack_ST.get ())
in ());
)))


let resize_ratio : uint32_t = (FStar_UInt32.uint_to_t ((Prims.parse_int "2")))


let new_capacity : uint32_t  ->  uint32_t = (fun ( cap  :  uint32_t ) -> (match ((FStar_UInt32.gte cap (FStar_UInt32.div max_uint32 resize_ratio))) with
| true -> begin
max_uint32
end
| uu___ -> begin
(match ((Prims.op_Equality cap (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
(FStar_UInt32.uint_to_t ((Prims.parse_int "1")))
end
| uu___1 -> begin
(FStar_UInt32.mul cap resize_ratio)
end)
end))


let insert = (fun ( vec  :  'a vector ) ( v  :  'a ) -> (

let sz = (match (vec) with
| Vec (sz1, cap, vs) -> begin
sz1
end)
in (

let cap = (match (vec) with
| Vec (sz1, cap1, vs) -> begin
cap1
end)
in (

let vs = (match (vec) with
| Vec (sz1, cap1, vs1) -> begin
vs1
end)
in (match ((Prims.op_Equality sz cap)) with
| true -> begin
(

let ncap = (new_capacity cap)
in (

let nvs = (LowStar_Monotonic_Buffer.mmalloc () v ncap)
in ((LowStar_Monotonic_Buffer.blit vs (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) nvs (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) sz);
(

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' nvs sz v));
(LowStar_Monotonic_Buffer.free vs);
Vec ((FStar_UInt32.add sz (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))), ncap, nvs);
)))
end
| uu___ -> begin
((

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' vs sz v));
Vec ((FStar_UInt32.add sz (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))), cap, vs);
)
end)))))


let flush = (fun ( vec  :  'a vector ) ( ia  :  'a ) ( i  :  uint32_t ) -> (

let fsz = (FStar_UInt32.sub (match (vec) with
| Vec (sz, cap, vs) -> begin
sz
end) i)
in (

let asz = (match ((Prims.op_Equality (match (vec) with
| Vec (sz, cap, vs) -> begin
sz
end) i)) with
| true -> begin
(FStar_UInt32.uint_to_t ((Prims.parse_int "1")))
end
| uu___ -> begin
fsz
end)
in (

let vs = (match (vec) with
| Vec (sz, cap, vs1) -> begin
vs1
end)
in (

let fvs = (LowStar_Monotonic_Buffer.mmalloc () ia asz)
in ((LowStar_Monotonic_Buffer.blit vs i fvs (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) fsz);
(LowStar_Monotonic_Buffer.free vs);
Vec (fsz, asz, fvs);
))))))


let shrink = (fun ( vec  :  'a vector ) ( new_size  :  uint32_t ) -> Vec (new_size, (match (vec) with
| Vec (sz, cap, vs) -> begin
cap
end), (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end)))


let rec fold_left_buffer = (fun ( len  :  uint32_t ) ( buf  :  'a LowStar_Buffer.buffer ) ( f  :  'b  ->  'a  ->  'b ) ( ib  :  'b ) -> (match ((Prims.op_Equality len (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
ib
end
| uu___ -> begin
(

let uu___1 = (LowStar_Monotonic_Buffer.msub buf (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))) ())
in (

let uu___2 = (

let uu___3 = (LowStar_Monotonic_Buffer.index buf (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))
in (f ib uu___3))
in (fold_left_buffer (FStar_UInt32.sub len (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))) uu___1 f uu___2)))
end))


let fold_left = (fun ( vec  :  'a vector ) ( f  :  'b  ->  'a  ->  'b ) ( ib  :  'b ) -> (

let uu___ = (LowStar_Monotonic_Buffer.msub (match (vec) with
| Vec (sz, cap, vs) -> begin
vs
end) (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) ())
in (fold_left_buffer (match (vec) with
| Vec (sz, cap, vs) -> begin
sz
end) uu___ f ib)))












