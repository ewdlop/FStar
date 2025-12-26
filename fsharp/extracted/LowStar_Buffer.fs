#light "off"
module LowStar_Buffer

type trivial_preorder =
unit


type 'a buffer =
('a, unit, unit) LowStar_Monotonic_Buffer.mbuffer


let null1 = (fun ( uu___  :  unit ) -> (LowStar_Monotonic_Buffer.mnull ()))


type 'a pointer =
'a buffer


type 'a pointer_or_null =
'a buffer


let sub = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.msub)


let offset = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.moffset)


type 'a lbuffer =
('a, unit, unit) LowStar_Monotonic_Buffer.mbuffer


let gcmalloc = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.mgcmalloc)


let malloc = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.mmalloc)


let alloca = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.malloca)


let alloca_of_list = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.malloca_of_list)


let gcmalloc_of_list = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.mgcmalloc_of_list)


type 'a assign_list_t =
'a buffer  ->  unit


let rec assign_list = (fun ( l  :  'a Prims.list ) ( b  :  'a buffer ) -> (match (l) with
| [] -> begin
(

let h = (FStar_HyperStack_ST.get ())
in ())
end
| (hd)::tl -> begin
(

let b_hd = (LowStar_Monotonic_Buffer.msub b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) ())
in (

let b_tl = (LowStar_Monotonic_Buffer.moffset b (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))))
in (

let h = (FStar_HyperStack_ST.get ())
in ((

let h1 = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' b_hd (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) hd));
(

let h0 = (FStar_HyperStack_ST.get ())
in ((assign_list tl b_tl);
(

let h1 = (FStar_HyperStack_ST.get ())
in ());
));
))))
end))




