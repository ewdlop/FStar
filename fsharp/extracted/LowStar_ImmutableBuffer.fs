#light "off"
module LowStar_ImmutableBuffer

type immutable_preorder =
FStar_Seq_Base.equal


type 'a ibuffer =
('a, immutable_preorder, immutable_preorder) LowStar_Monotonic_Buffer.mbuffer


let inull = (fun ( uu___  :  unit ) -> (LowStar_Monotonic_Buffer.mnull ()))


type 'a ipointer =
'a ibuffer


type 'a ipointer_or_null =
'a ibuffer


let isub = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.msub)


let ioffset = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.moffset)


type cpred =
FStar_Seq_Base.equal


type seq_eq =
FStar_Seq_Base.equal


type ('a, 'b) value_is =
('a, immutable_preorder, immutable_preorder, 'b, seq_eq) LowStar_Monotonic_Buffer.witnessed


type 'a libuffer =
('a, immutable_preorder, immutable_preorder) LowStar_Monotonic_Buffer.mbuffer


type 'a libuffer_or_null =
('a, immutable_preorder, immutable_preorder) LowStar_Monotonic_Buffer.mbuffer


let igcmalloc = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (

let b = (LowStar_Monotonic_Buffer.mgcmalloc () init len)
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
)))


let igcmalloc_and_blit = (fun ( r  :  unit ) ( rrel1  :  unit ) ( rel1  :  unit ) ( src  :  ('a, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( id_src  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let b = (LowStar_Monotonic_Buffer.mgcmalloc_and_blit () () () src id_src len)
in (

let h0 = (FStar_HyperStack_ST.get ())
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
))))


let igcmalloc_partial = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (igcmalloc () init len))


let imalloc = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (

let b = (LowStar_Monotonic_Buffer.mmalloc () init len)
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
)))


let imalloc_and_blit = (fun ( r  :  unit ) ( rrel1  :  unit ) ( rel1  :  unit ) ( src  :  ('a, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( id_src  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let b = (LowStar_Monotonic_Buffer.mmalloc_and_blit () () () src id_src len)
in (

let h0 = (FStar_HyperStack_ST.get ())
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
))))


let imalloc_partial = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (imalloc () init len))


let ialloca = (fun ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (

let b = (LowStar_Monotonic_Buffer.malloca init len)
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
)))


let ialloca_and_blit = (fun ( src  :  ('a, 'rrel1, 'rel1) LowStar_Monotonic_Buffer.mbuffer ) ( id_src  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let b = (LowStar_Monotonic_Buffer.malloca_and_blit src id_src len)
in (

let h0 = (FStar_HyperStack_ST.get ())
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
))))


let ialloca_of_list = (fun ( init  :  'a Prims.list ) -> (

let b = (LowStar_Monotonic_Buffer.malloca_of_list init)
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
)))


let igcmalloc_of_list = (fun ( r  :  unit ) ( init  :  'a Prims.list ) -> (

let b = (LowStar_Monotonic_Buffer.mgcmalloc_of_list () init)
in ((LowStar_Monotonic_Buffer.witness_p b ());
b;
)))


let igcmalloc_of_list_partial = (fun ( r  :  unit ) ( init  :  'a Prims.list ) -> (igcmalloc_of_list () init))


let witness_contents = (fun ( b  :  'a ibuffer ) ( s  :  'a FStar_Seq_Base.seq ) -> (LowStar_Monotonic_Buffer.witness_p b ()))


let recall_contents = (fun ( b  :  'a ibuffer ) ( s  :  'a FStar_Seq_Base.seq ) -> (LowStar_Monotonic_Buffer.recall_p b ()))


let witness_value = (fun ( b  :  'a ibuffer ) -> (

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.witness_p b ())))


let recall_value = (fun ( b  :  'a ibuffer ) ( s  :  unit ) -> (LowStar_Monotonic_Buffer.recall_p b ()))




