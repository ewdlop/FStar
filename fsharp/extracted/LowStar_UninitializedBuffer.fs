#light "off"
module LowStar_UninitializedBuffer

type initialization_preorder =
unit


type 'a ubuffer =
('a FStar_Pervasives_Native.option, unit, unit) LowStar_Monotonic_Buffer.mbuffer


let unull = (fun ( uu___  :  unit ) -> (LowStar_Monotonic_Buffer.mnull ()))


type 'a pointer =
'a ubuffer


type 'a pointer_or_null =
'a ubuffer


let usub = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.msub)


let uoffset = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.moffset)


type ipred =
unit


type ('a, 'b) initialized_at =
('a FStar_Pervasives_Native.option, unit, unit, 'b, unit) LowStar_Monotonic_Buffer.witnessed


let uindex = (fun ( b  :  'a ubuffer ) ( i  :  FStar_UInt32.t ) -> (

let y_opt = (LowStar_Monotonic_Buffer.index b i)
in ((LowStar_Monotonic_Buffer.recall_p b ());
(FStar_Pervasives_Native.__proj__Some__item__v y_opt);
)))


let uupd = (fun ( b  :  'a ubuffer ) ( i  :  FStar_UInt32.t ) ( v  :  'a ) -> ((

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' b i (FStar_Pervasives_Native.Some (v))));
(LowStar_Monotonic_Buffer.witness_p b ());
))


type 'a lubuffer =
'a ubuffer


type 'a lubuffer_or_null =
'a ubuffer


let ugcmalloc = (fun ( r  :  unit ) ( len  :  FStar_UInt32.t ) -> (LowStar_Monotonic_Buffer.mgcmalloc () FStar_Pervasives_Native.None len))


let ugcmalloc_partial = (fun ( r  :  unit ) ( len  :  FStar_UInt32.t ) -> (LowStar_Monotonic_Buffer.mgcmalloc () FStar_Pervasives_Native.None len))


let umalloc = (fun ( r  :  unit ) ( len  :  FStar_UInt32.t ) -> (LowStar_Monotonic_Buffer.mmalloc () FStar_Pervasives_Native.None len))


let umalloc_partial = (fun ( r  :  unit ) ( len  :  FStar_UInt32.t ) -> (LowStar_Monotonic_Buffer.mmalloc () FStar_Pervasives_Native.None len))


let ualloca = (fun ( len  :  FStar_UInt32.t ) -> (LowStar_Monotonic_Buffer.malloca FStar_Pervasives_Native.None len))


type valid_j_for_blit =
unit


type ublit_post_j =
unit


let ublit = (fun ( src  :  ('a, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( idx_src  :  FStar_UInt32.t ) ( dst  :  'a ubuffer ) ( idx_dst  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let rec aux : FStar_UInt32.t  ->  unit = (fun ( j  :  FStar_UInt32.t ) -> (match ((Prims.op_Equality j len)) with
| true -> begin
()
end
| uu___ -> begin
(match ((FStar_UInt32.lt j len)) with
| true -> begin
((

let uu___2 = (LowStar_Monotonic_Buffer.index src (FStar_UInt32.add idx_src j))
in (uupd dst (FStar_UInt32.add idx_dst j) uu___2));
(aux (FStar_UInt32.add j (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))));
)
end
| uu___1 -> begin
()
end)
end))
in (aux (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))))


let witness_initialized = (fun ( b  :  'a ubuffer ) ( i  :  Prims.nat ) -> (LowStar_Monotonic_Buffer.witness_p b ()))


let recall_initialized = (fun ( b  :  'a ubuffer ) ( i  :  Prims.nat ) -> (LowStar_Monotonic_Buffer.recall_p b ()))




