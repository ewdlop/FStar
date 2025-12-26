#light "off"
module LowStar_Lens_Buffer
type flav =
| Buffer
| Pointer


let uu___is_Buffer : flav  ->  Prims.bool = (fun ( projectee  :  flav ) -> (match (projectee) with
| Buffer -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Pointer : flav  ->  Prims.bool = (fun ( projectee  :  flav ) -> (match (projectee) with
| Pointer -> begin
true
end
| uu___ -> begin
false
end))


type ok_for_ptr =
unit


type flavor =
flav


let ptr = (fun ( b  :  'a LowStar_Buffer.buffer ) -> Pointer)


let buf = (fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) -> Buffer)


type 'a lseq_of =
'a FStar_Seq_Properties.lseq


type view_type_of =
obj


type ('a, 'p, 'q) buffer_hs_lens =
(('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer, obj) LowStar_Lens.hs_lens


let get_value_at = (fun ( uu___3  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( uu___2  :  flavor ) ( uu___1  :  obj ) ( uu___  :  FStar_UInt32.t ) -> ((fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( v  :  obj ) ( i  :  FStar_UInt32.t ) -> (match (f) with
| Pointer -> begin
(Prims.unsafe_coerce (box v))
end
| Buffer -> begin
(Prims.unsafe_coerce (box (FStar_Seq_Base.index (Prims.unsafe_coerce v) (FStar_UInt32.v i))))
end)) uu___3 uu___2 uu___1 uu___))


let put_value_at = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( v0  :  obj ) ( i  :  FStar_UInt32.t ) ( x  :  'a ) -> (match (f) with
| Pointer -> begin
(box x)
end
| Buffer -> begin
(box (FStar_Seq_Base.upd (Prims.unsafe_coerce v0) (FStar_UInt32.v i) x))
end))


let as_seq = (fun ( uu___2  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( uu___1  :  flavor ) ( uu___  :  obj ) -> ((fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( v0  :  obj ) -> (match (f) with
| Pointer -> begin
(Prims.unsafe_coerce (box (FStar_Seq_Base.create (Prims.parse_int "1") (Prims.unsafe_coerce v0))))
end
| Buffer -> begin
(Prims.unsafe_coerce (box v0))
end)) uu___2 uu___1 uu___))


type 't with_state =
LowStar_Lens.imem  ->  't


type ix =
FStar_UInt32.t


type 'a reader_t =
ix  ->  'a


type 'a writer_t =
ix  ->  'a  ->  unit


let id_lens = (fun ( uu___  :  unit ) -> {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()})

type ('a, 'p, 'q, 'b, 'f) buffer_lens =
| Mk of ('a, 'p, 'q) buffer_hs_lens * 'a reader_t with_state * 'a writer_t with_state


let uu___is_Mk = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( projectee  :  ('a, 'p, 'q, obj, obj) buffer_lens ) -> true)


let __proj__Mk__item__hs_lens = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( projectee  :  ('a, 'p, 'q, obj, obj) buffer_lens ) -> (match (projectee) with
| Mk (hs_lens, reader, writer) -> begin
hs_lens
end))


let __proj__Mk__item__reader = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( projectee  :  ('a, 'p, 'q, obj, obj) buffer_lens ) -> (match (projectee) with
| Mk (hs_lens, reader, writer) -> begin
reader
end))


let __proj__Mk__item__writer = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( projectee  :  ('a, 'p, 'q, obj, obj) buffer_lens ) -> (match (projectee) with
| Mk (hs_lens, reader, writer) -> begin
writer
end))


let lens_of = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( prw  :  ('a, 'p, 'q, obj, obj) buffer_lens ) -> (__proj__Mk__item__hs_lens b f prw))


let mk = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( snap  :  FStar_Monotonic_HyperStack.mem ) -> (

let blens = (

let l = {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()}
in {LowStar_Lens.footprint = (); LowStar_Lens.invariant = (); LowStar_Lens.x = b; LowStar_Lens.snapshot = snap; LowStar_Lens.l = l})
in (

let reader = (fun ( s  :  LowStar_Lens.imem ) ( i  :  ix ) -> (LowStar_Monotonic_Buffer.index b i))
in (

let writer = (fun ( s  :  LowStar_Lens.imem ) ( i  :  ix ) ( v  :  'a ) -> (

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' b i v)))
in Mk (blens, reader, writer)))))


let index = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( bl  :  ('a, 'p, 'q, obj, obj) buffer_lens ) ( i  :  ix ) -> (

let h = (FStar_HyperStack_ST.get ())
in (__proj__Mk__item__reader b f bl h i)))


let upd = (fun ( b  :  ('a, 'p, 'q) LowStar_Monotonic_Buffer.mbuffer ) ( f  :  flavor ) ( bl  :  ('a, 'p, 'q, obj, obj) buffer_lens ) ( i  :  ix ) ( v  :  'a ) -> (

let h = (FStar_HyperStack_ST.get ())
in (__proj__Mk__item__writer b f bl h i v)))




