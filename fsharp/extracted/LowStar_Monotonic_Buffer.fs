#light "off"
module LowStar_Monotonic_Buffer

type srel =
unit


type compatible_subseq_preorder =
unit


type 'pre srel_to_lsrel =
'pre


type compatible_sub_preorder =
unit

type ('a, 'rrel, 'rel) mbuffer =
| Null
| Buffer of FStar_UInt32.t * ('a FStar_Seq_Properties.lseq, 'rrel srel_to_lsrel) FStar_HyperStack_ST.mreference * FStar_UInt32.t * unit


let uu___is_Null = (fun ( projectee  :  ('a, 'rrel, 'rel) mbuffer ) -> (match (projectee) with
| Null -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Buffer = (fun ( projectee  :  ('a, 'rrel, 'rel) mbuffer ) -> (match (projectee) with
| Buffer (max_length, content, idx, length) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Buffer__item__max_length = (fun ( projectee  :  ('a, 'rrel, 'rel) mbuffer ) -> (match (projectee) with
| Buffer (max_length, content, idx, length) -> begin
max_length
end))


let __proj__Buffer__item__content = (fun ( projectee  :  ('a, 'rrel, 'rel) mbuffer ) -> (match (projectee) with
| Buffer (max_length, content, idx, length) -> begin
content
end))


let __proj__Buffer__item__idx = (fun ( projectee  :  ('a, 'rrel, 'rel) mbuffer ) -> (match (projectee) with
| Buffer (max_length, content, idx, length) -> begin
idx
end))


let mnull = (fun ( uu___  :  unit ) -> Null)



type buffer_compatible =
obj






type compatible_sub =
unit

type ubuffer_ =
{b_max_length : Prims.nat; b_offset : Prims.nat; b_length : Prims.nat; b_is_mm : Prims.bool}


let __proj__Mkubuffer___item__b_max_length : ubuffer_  ->  Prims.nat = (fun ( projectee  :  ubuffer_ ) -> (match (projectee) with
| {b_max_length = b_max_length; b_offset = b_offset; b_length = b_length; b_is_mm = b_is_mm} -> begin
b_max_length
end))


let __proj__Mkubuffer___item__b_offset : ubuffer_  ->  Prims.nat = (fun ( projectee  :  ubuffer_ ) -> (match (projectee) with
| {b_max_length = b_max_length; b_offset = b_offset; b_length = b_length; b_is_mm = b_is_mm} -> begin
b_offset
end))


let __proj__Mkubuffer___item__b_length : ubuffer_  ->  Prims.nat = (fun ( projectee  :  ubuffer_ ) -> (match (projectee) with
| {b_max_length = b_max_length; b_offset = b_offset; b_length = b_length; b_is_mm = b_is_mm} -> begin
b_length
end))


let __proj__Mkubuffer___item__b_is_mm : ubuffer_  ->  Prims.bool = (fun ( projectee  :  ubuffer_ ) -> (match (projectee) with
| {b_max_length = b_max_length; b_offset = b_offset; b_length = b_length; b_is_mm = b_is_mm} -> begin
b_is_mm
end))



type ubuffer =
unit





type ubuffer_preserved' =
unit






type ubuffer_includes' =
unit


type ubuffer_includes0 =
unit



type ubuffer_disjoint' =
obj


type ubuffer_disjoint0 =
unit



type modifies_0_preserves_mreferences =
unit


type modifies_0_preserves_regions =
unit


type modifies_0_preserves_not_unused_in =
unit


type modifies_0' =
unit



type modifies_1_preserves_mreferences =
unit


type modifies_1_preserves_ubuffers =
unit


type modifies_1_from_to_preserves_ubuffers =
unit


type modifies_1_preserves_livenesses =
unit


type modifies_1' =
unit



type modifies_1_from_to =
obj


type modifies_addr_of_preserves_not_unused_in =
unit


type modifies_addr_of' =
unit



type loc =
unit




type buf_t =
(unit, unit, unit, (obj, obj, obj) mbuffer) FStar_Pervasives.dtuple4


let buf = (fun ( b  :  ('a, 'rrel, 'rel) mbuffer ) -> FStar_Pervasives.Mkdtuple4 ((), (), (), (Prims.unsafe_coerce b)))


type all_live =
obj


type all_disjoint =
obj


type loc_pairwise_disjoint =
obj




type loc_in =
unit


type loc_not_in =
unit


type fresh_loc =
unit


type disjoint =
unit


type includes =
unit


type ('a, 'rrel, 'rel) mpointer =
('a, 'rrel, 'rel) mbuffer


type ('a, 'rrel, 'rel) mpointer_or_null =
('a, 'rrel, 'rel) mbuffer


let is_null = (fun ( b  :  ('uuuuu, 'uuuuu1, 'uuuuu2) mbuffer ) -> (uu___is_Null b))


let msub = (fun ( b  :  ('a, 'rrel, 'rel) mbuffer ) ( i  :  FStar_UInt32.t ) ( len  :  unit ) -> (match (b) with
| Null -> begin
Null
end
| Buffer (max_len, content, i0, len0) -> begin
Buffer (max_len, content, (FStar_UInt32.add i0 i), ())
end))


let moffset = (fun ( b  :  ('a, 'rrel, 'rel) mbuffer ) ( i  :  FStar_UInt32.t ) -> (match (b) with
| Null -> begin
Null
end
| Buffer (max_len, content, i0, len) -> begin
Buffer (max_len, content, (FStar_UInt32.add i0 i), ())
end))


let index = (fun ( b  :  ('uuuuu, 'uuuuu1, 'uuuuu2) mbuffer ) ( i  :  FStar_UInt32.t ) -> (

let s = (FStar_HyperStack_ST.op_Bang (__proj__Buffer__item__content b))
in (FStar_Seq_Base.index s ((FStar_UInt32.v (__proj__Buffer__item__idx b)) + (FStar_UInt32.v i)))))


let upd' = (fun ( b  :  ('uuuuu, 'uuuuu1, 'uuuuu2) mbuffer ) ( i  :  FStar_UInt32.t ) ( v  :  'uuuuu ) -> (

let h = (FStar_HyperStack_ST.get ())
in (

let uu___ = b
in (match (uu___) with
| Buffer (max_length, content, idx, len) -> begin
(

let s0 = (FStar_HyperStack_ST.op_Bang content)
in (

let sb0 = (FStar_Seq_Base.slice s0 (FStar_UInt32.v idx) (FStar_UInt32.v max_length))
in (

let s_upd = (FStar_Seq_Base.upd sb0 (FStar_UInt32.v i) v)
in (

let sf = (FStar_Seq_Properties.replace_subseq s0 (FStar_UInt32.v idx) (FStar_UInt32.v max_length) s_upd)
in (FStar_HyperStack_ST.op_Colon_Equals content sf)))))
end))))


let upd = (fun ( b  :  ('a, 'rrel, 'rel) mbuffer ) ( i  :  FStar_UInt32.t ) ( v  :  'a ) -> (

let h = (FStar_HyperStack_ST.get ())
in (upd' b i v)))




type rrel_rel_always_compatible =
unit


let recall = (fun ( b  :  ('uuuuu, 'uuuuu1, 'uuuuu2) mbuffer ) -> (match ((uu___is_Null b)) with
| true -> begin
()
end
| uu___ -> begin
(FStar_HyperStack_ST.recall (__proj__Buffer__item__content b))
end))


type spred =
unit


type stable_on =
unit


type spred_as_mempred =
unit



let witness_p = (fun ( b  :  ('a, 'rrel, 'rel) mbuffer ) ( p  :  unit ) -> (match (b) with
| Null -> begin
()
end
| Buffer (uu___, content, uu___1, uu___2) -> begin
(FStar_HyperStack_ST.witness_p content ())
end))


let recall_p = (fun ( b  :  ('uuuuu, 'uuuuu1, 'uuuuu2) mbuffer ) ( p  :  unit ) -> (match (b) with
| Null -> begin
()
end
| Buffer (uu___, content, uu___1, uu___2) -> begin
(FStar_HyperStack_ST.recall_p content ())
end))


let witnessed_functorial_st = (fun ( b1  :  ('a, 'rrel, 'rel1) mbuffer ) ( b2  :  ('a, 'rrel, 'rel2) mbuffer ) ( i  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) ( s1  :  unit ) ( s2  :  unit ) -> ())



let free = (fun ( b  :  ('uuuuu, 'uuuuu1, 'uuuuu2) mbuffer ) -> (FStar_HyperStack_ST.rfree (__proj__Buffer__item__content b)))


type ('a, 'rrel, 'rel) lmbuffer =
('a, 'rrel, 'rel) mbuffer


type alloc_post_mem_common =
unit


type ('a, 'rrel, 'rel) lmbuffer_or_null =
('a, 'rrel, 'rel) mbuffer


type alloc_partial_post_mem_common =
unit


type malloc_pre =
unit


let alloc_heap_common = (fun ( r  :  unit ) ( len  :  FStar_UInt32.t ) ( s  :  'a FStar_Seq_Base.seq ) ( mm  :  Prims.bool ) -> (

let content = (match (mm) with
| true -> begin
(FStar_HyperStack_ST.ralloc_mm () s)
end
| uu___ -> begin
(FStar_HyperStack_ST.ralloc () s)
end)
in (

let b = Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())
in b)))


let mgcmalloc = (fun ( r  :  unit ) ( init  :  'uuuuu ) ( len  :  FStar_UInt32.t ) -> (alloc_heap_common () len (FStar_Seq_Base.create (FStar_UInt32.v len) init) false))


let read_sub_buffer = (fun ( b  :  ('a, 'rrel, 'rel) mbuffer ) ( idx  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let s = (FStar_HyperStack_ST.op_Bang (__proj__Buffer__item__content b))
in (

let s1 = (FStar_Seq_Base.slice s (FStar_UInt32.v (__proj__Buffer__item__idx b)) (FStar_UInt32.v (__proj__Buffer__item__max_length b)))
in (FStar_Seq_Base.slice s1 (FStar_UInt32.v idx) ((FStar_UInt32.v idx) + (FStar_UInt32.v len))))))


let mgcmalloc_and_blit = (fun ( r  :  unit ) ( uu___  :  unit ) ( uu___1  :  unit ) ( src  :  ('uuuuu, obj, obj) mbuffer ) ( id_src  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let uu___2 = (read_sub_buffer src id_src len)
in (alloc_heap_common () len uu___2 false)))


let mgcmalloc_partial = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (mgcmalloc () init len))


let mmalloc = (fun ( r  :  unit ) ( init  :  'uuuuu ) ( len  :  FStar_UInt32.t ) -> (alloc_heap_common () len (FStar_Seq_Base.create (FStar_UInt32.v len) init) true))


let mmalloc_and_blit = (fun ( r  :  unit ) ( uu___  :  unit ) ( uu___1  :  unit ) ( src  :  ('uuuuu, obj, obj) mbuffer ) ( id_src  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let uu___2 = (read_sub_buffer src id_src len)
in (alloc_heap_common () len uu___2 true)))


let mmalloc_partial = (fun ( r  :  unit ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (mmalloc () init len))


let alloca_pre : FStar_UInt32.t  ->  Prims.bool = (fun ( len  :  FStar_UInt32.t ) -> ((FStar_UInt32.v len) > (Prims.parse_int "0")))


let malloca = (fun ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (

let content = (FStar_HyperStack_ST.salloc (FStar_Seq_Base.create (FStar_UInt32.v len) init))
in Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())))


let malloca_and_blit = (fun ( src  :  ('a, 'uuuuu, 'uuuuu1) mbuffer ) ( id_src  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let content = (

let uu___ = (read_sub_buffer src id_src len)
in (FStar_HyperStack_ST.salloc uu___))
in Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())))


type alloca_of_list_pre =
unit


let malloca_of_list = (fun ( init  :  'a Prims.list ) -> (

let len = (FStar_UInt32.uint_to_t (FStar_List_Tot_Base.length init))
in (

let s = (FStar_Seq_Base.seq_of_list init)
in (

let content = (FStar_HyperStack_ST.salloc s)
in Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())))))


type gcmalloc_of_list_pre =
unit


let mgcmalloc_of_list = (fun ( r  :  unit ) ( init  :  'a Prims.list ) -> (

let len = (FStar_UInt32.uint_to_t (FStar_List_Tot_Base.length init))
in (

let s = (FStar_Seq_Base.seq_of_list init)
in (

let content = (FStar_HyperStack_ST.ralloc () s)
in Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())))))


let mgcmalloc_of_list_partial = (fun ( r  :  unit ) ( init  :  'a Prims.list ) -> (mgcmalloc_of_list () init))


type alloc_drgn_pre =
unit


let mmalloc_drgn = (fun ( d  :  FStar_HyperStack_ST.drgn ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (

let content = (FStar_HyperStack_ST.ralloc_drgn d (FStar_Seq_Base.create (FStar_UInt32.v len) init))
in Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())))


let mmalloc_drgn_mm = (fun ( d  :  FStar_HyperStack_ST.drgn ) ( init  :  'a ) ( len  :  FStar_UInt32.t ) -> (

let content = (FStar_HyperStack_ST.ralloc_drgn_mm d (FStar_Seq_Base.create (FStar_UInt32.v len) init))
in Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())))


let mmalloc_drgn_and_blit = (fun ( d  :  FStar_HyperStack_ST.drgn ) ( src  :  ('a, 'uuuuu, 'uuuuu1) mbuffer ) ( id_src  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (

let content = (

let uu___ = (read_sub_buffer src id_src len)
in (FStar_HyperStack_ST.ralloc_drgn d uu___))
in Buffer (len, content, (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), ())))


let blit = (fun ( src  :  ('a, 'rrel1, 'rel1) mbuffer ) ( idx_src  :  FStar_UInt32.t ) ( dst  :  ('a, 'rrel2, 'rel2) mbuffer ) ( idx_dst  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> (match (((src), (dst))) with
| (Buffer (uu___, uu___1, uu___2, uu___3), Buffer (uu___4, uu___5, uu___6, uu___7)) -> begin
(match ((Prims.op_Equality len (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
()
end
| uu___8 -> begin
(

let h = (FStar_HyperStack_ST.get ())
in (

let uu___9 = src
in (match (uu___9) with
| Buffer (max_length1, content1, idx1, length1) -> begin
(

let uu___10 = dst
in (match (uu___10) with
| Buffer (max_length2, content2, idx2, length2) -> begin
(

let s_full1 = (FStar_HyperStack_ST.op_Bang content1)
in (

let s_full2 = (FStar_HyperStack_ST.op_Bang content2)
in (

let s1 = (FStar_Seq_Base.slice s_full1 (FStar_UInt32.v idx1) (FStar_UInt32.v max_length1))
in (

let s2 = (FStar_Seq_Base.slice s_full2 (FStar_UInt32.v idx2) (FStar_UInt32.v max_length2))
in (

let s_sub_src = (FStar_Seq_Base.slice s1 (FStar_UInt32.v idx_src) ((FStar_UInt32.v idx_src) + (FStar_UInt32.v len)))
in (

let s2' = (FStar_Seq_Properties.replace_subseq s2 (FStar_UInt32.v idx_dst) ((FStar_UInt32.v idx_dst) + (FStar_UInt32.v len)) s_sub_src)
in (

let s_full2' = (FStar_Seq_Properties.replace_subseq s_full2 (FStar_UInt32.v idx2) (FStar_UInt32.v max_length2) s2')
in ((FStar_HyperStack_ST.op_Colon_Equals content2 s_full2');
(

let h1 = (FStar_HyperStack_ST.get ())
in ());
))))))))
end))
end)))
end)
end
| (uu___, uu___1) -> begin
()
end))


let fill' = (fun ( b  :  ('t, 'rrel, 'rel) mbuffer ) ( z  :  't ) ( len  :  FStar_UInt32.t ) -> (match ((Prims.op_Equality len (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
()
end
| uu___ -> begin
(

let h = (FStar_HyperStack_ST.get ())
in (

let uu___1 = b
in (match (uu___1) with
| Buffer (max_length, content, idx, length) -> begin
(

let s_full = (FStar_HyperStack_ST.op_Bang content)
in (

let s = (FStar_Seq_Base.slice s_full (FStar_UInt32.v idx) (FStar_UInt32.v max_length))
in (

let s_src = (FStar_Seq_Base.create (FStar_UInt32.v len) z)
in (

let s' = (FStar_Seq_Properties.replace_subseq s (Prims.parse_int "0") (FStar_UInt32.v len) s_src)
in (

let s_full' = (FStar_Seq_Properties.replace_subseq s_full (FStar_UInt32.v idx) ((FStar_UInt32.v idx) + (FStar_UInt32.v len)) s_src)
in ((FStar_HyperStack_ST.op_Colon_Equals content s_full');
(

let h' = (FStar_HyperStack_ST.get ())
in ());
))))))
end)))
end))


let fill = (fun ( b  :  ('t, 'rrel, 'rel) mbuffer ) ( z  :  't ) ( len  :  FStar_UInt32.t ) -> (fill' b z len))


type ('region, 'addr) abuffer' =
('region, 'addr) ubuffer'


type abuffer =
unit


let coerce = (fun ( uu___  :  't1 ) -> ((fun ( x1  :  't1 ) -> (Prims.unsafe_coerce x1)) uu___))




