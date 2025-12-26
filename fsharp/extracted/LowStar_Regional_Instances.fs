#light "off"
module LowStar_Regional_Instances

let buffer_dummy = (fun ( uu___  :  unit ) -> (LowStar_Monotonic_Buffer.mnull ()))


type nonzero =
FStar_UInt32.t





let buffer_r_alloc = (fun ( uu___  :  unit ) ( uu___1  :  ('a * nonzero) ) ( r  :  unit ) -> (match (uu___1) with
| (ia, len) -> begin
(LowStar_Monotonic_Buffer.mmalloc () ia len)
end))


let buffer_r_free = (fun ( uu___  :  unit ) ( len  :  ('a * nonzero) ) ( v  :  'a LowStar_Buffer.buffer ) -> (LowStar_Monotonic_Buffer.free v))


let buffer_copy = (fun ( uu___  :  unit ) ( uu___1  :  ('a * nonzero) ) ( src  :  'a LowStar_Buffer.buffer ) ( dst  :  'a LowStar_Buffer.buffer ) -> (match (uu___1) with
| (ia, len) -> begin
(LowStar_Monotonic_Buffer.blit src (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) dst (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) len)
end))


let buffer_regional = (fun ( ia  :  'a ) ( len  :  nonzero ) -> LowStar_Regional.Rgl (((ia), (len)), (), (), (buffer_dummy ()), (), (), (), (), (), (), (), (buffer_r_alloc ()), (buffer_r_free ())))


let buffer_copyable = (fun ( ia  :  'a ) ( len  :  nonzero ) -> LowStar_RVector.Cpy ((buffer_copy ())))


let vector_dummy = (fun ( uu___  :  unit ) -> LowStar_Vector.Vec ((FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (LowStar_Monotonic_Buffer.mnull ())))





let vector_r_alloc = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( r  :  unit ) -> ((FStar_HyperStack_ST.new_region ());
(LowStar_Vector.alloc_reserve (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))) (LowStar_Regional.__proj__Rgl__item__dummy rg) ());
))


let vector_r_free = (fun ( uu___  :  unit ) ( uu___1  :  ('uuuuu1, 'uuuuu) LowStar_Regional.regional ) ( v  :  'uuuuu LowStar_RVector.rvector ) -> (LowStar_Vector.free v))


let vector_regional = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) -> LowStar_Regional.Rgl (rg, (), (), (vector_dummy ()), (), (), (), (), (), (), (), vector_r_alloc, (vector_r_free ())))




