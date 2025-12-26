#light "off"
module LowStar_BufferCompat

type rcreate_post_mem_common =
unit


let rfree = (fun ( b  :  'a LowStar_Buffer.buffer ) -> (LowStar_Monotonic_Buffer.free b))


let rcreate = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (

let b = (LowStar_Monotonic_Buffer.mgcmalloc () init len)
in b))


let rcreate_mm = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (LowStar_Monotonic_Buffer.mmalloc () init len))


let create = (fun ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (LowStar_Monotonic_Buffer.malloca init len))


type createL_pre =
unit


let createL = (fun ( init  :  'a Prims.list ) -> (LowStar_Monotonic_Buffer.malloca_of_list init))




