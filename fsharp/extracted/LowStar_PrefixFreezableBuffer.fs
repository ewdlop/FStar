#light "off"
module LowStar_PrefixFreezableBuffer

type u8 =
FStar_UInt8.t


type u32 =
FStar_UInt32.t


let le_to_n : u8 FStar_Seq_Base.seq  ->  Prims.nat = (fun ( s  :  u8 FStar_Seq_Base.seq ) -> (FStar_Endianness.le_to_n s))


let frozen_until : u8 FStar_Seq_Base.seq  ->  Prims.nat = (fun ( s  :  u8 FStar_Seq_Base.seq ) -> (le_to_n (FStar_Seq_Base.slice s (Prims.parse_int "0") (Prims.parse_int "4"))))


type pre =
unit



type frozen_until_at_least =
unit


type slice_is =
unit


type buffer =
(u8, unit, unit) LowStar_Monotonic_Buffer.mbuffer


type lbuffer =
buffer


type malloc_pre =
unit


type alloc_post_mem_common =
unit


let update_frozen_until_alloc : (u8, (unit, unit) prefix_freezable_preorder, (unit, unit) prefix_freezable_preorder) LowStar_Monotonic_Buffer.mbuffer  ->  unit = (fun ( b  :  (u8, (unit, unit) prefix_freezable_preorder, (unit, unit) prefix_freezable_preorder) LowStar_Monotonic_Buffer.mbuffer ) -> ((LowStar_Endianness.store32_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) (FStar_UInt32.uint_to_t ((Prims.parse_int "4"))));
(LowStar_Monotonic_Buffer.witness_p b ());
))


let gcmalloc : unit  ->  u32  ->  buffer = (fun ( r  :  unit ) ( len  :  u32 ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (

let b = (LowStar_Monotonic_Buffer.mgcmalloc () 0 (FStar_UInt32.add len (FStar_UInt32.uint_to_t ((Prims.parse_int "4")))))
in (

let h = (FStar_HyperStack_ST.get ())
in ((update_frozen_until_alloc b);
b;
)))))


let malloc : unit  ->  u32  ->  buffer = (fun ( r  :  unit ) ( len  :  u32 ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (

let b = (LowStar_Monotonic_Buffer.mmalloc () 0 (FStar_UInt32.add len (FStar_UInt32.uint_to_t ((Prims.parse_int "4")))))
in (

let h = (FStar_HyperStack_ST.get ())
in ((update_frozen_until_alloc b);
b;
)))))


type alloca_pre =
unit


let alloca : u32  ->  buffer = (fun ( len  :  u32 ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (

let b = (LowStar_Monotonic_Buffer.malloca 0 (FStar_UInt32.add len (FStar_UInt32.uint_to_t ((Prims.parse_int "4")))))
in (

let h = (FStar_HyperStack_ST.get ())
in ((update_frozen_until_alloc b);
b;
)))))


let upd : buffer  ->  u32  ->  u8  ->  unit = (fun ( b  :  buffer ) ( i  :  u32 ) ( v  :  u8 ) -> ((LowStar_Monotonic_Buffer.recall_p b ());
(

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' b i v));
))


let freeze : buffer  ->  u32  ->  unit = (fun ( b  :  buffer ) ( i  :  u32 ) -> ((LowStar_Monotonic_Buffer.recall_p b ());
(LowStar_Endianness.store32_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) i);
(LowStar_Monotonic_Buffer.witness_p b ());
))


let frozen_until_st : buffer  ->  u32 = (fun ( b  :  buffer ) -> (LowStar_Endianness.load32_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let witness_slice : buffer  ->  u32  ->  u32  ->  unit  ->  unit = (fun ( b  :  buffer ) ( i  :  u32 ) ( j  :  u32 ) ( snap  :  unit ) -> (LowStar_Monotonic_Buffer.witness_p b ()))


let recall_slice : buffer  ->  u32  ->  u32  ->  unit  ->  unit = (fun ( b  :  buffer ) ( i  :  u32 ) ( j  :  u32 ) ( snap  :  unit ) -> (LowStar_Monotonic_Buffer.recall_p b ()))


let witness_frozen_until : buffer  ->  Prims.nat  ->  unit = (fun ( b  :  buffer ) ( n  :  Prims.nat ) -> (LowStar_Monotonic_Buffer.witness_p b ()))


let recall_frozen_until : buffer  ->  Prims.nat  ->  unit = (fun ( b  :  buffer ) ( n  :  Prims.nat ) -> (LowStar_Monotonic_Buffer.recall_p b ()))


let recall_frozen_until_default : buffer  ->  unit = (fun ( b  :  buffer ) -> (LowStar_Monotonic_Buffer.recall_p b ()))




