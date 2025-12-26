#light "off"
module LowStar_Lens_Tuple2

type composable =
unit


let mk = (fun ( l1  :  ('a1, 'b1) LowStar_Lens.hs_lens ) ( a2  :  unit ) ( b2  :  unit ) ( l2  :  (obj, obj) LowStar_Lens.hs_lens ) -> (

let x = ((l1.x), (l2.x))
in (

let snap = l1.snapshot
in (

let l = {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()}
in {LowStar_Lens.footprint = (); LowStar_Lens.invariant = (); LowStar_Lens.x = x; LowStar_Lens.snapshot = snap; LowStar_Lens.l = l}))))


let op_fst = (fun ( l1  :  ('a, 'b) LowStar_Lens.hs_lens ) ( l2  :  ('c, 'd) LowStar_Lens.hs_lens ) ( op  :  'result LowStar_Lens.with_snapshot ) -> (

let s = (FStar_HyperStack_ST.get ())
in (op s)))


let op_snd = (fun ( l1  :  ('a, 'b) LowStar_Lens.hs_lens ) ( l2  :  ('c, 'd) LowStar_Lens.hs_lens ) ( op  :  'result LowStar_Lens.with_snapshot ) -> (

let s = (FStar_HyperStack_ST.get ())
in (op s)))


let lens_fst = (fun ( uu___  :  unit ) -> {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()})


let lens_snd = (fun ( uu___  :  unit ) -> {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()})

type ('a1, 'p1, 'q1, 'b1, 'f1, 'a2, 'p2, 'q2, 'b2, 'f2) tup2_t =
| Mk of ('a1, 'p1, 'q1, 'b1, 'f1) LowStar_Lens_Buffer.buffer_lens * ('a2, 'p2, 'q2, 'b2, 'f2) LowStar_Lens_Buffer.buffer_lens * 'a1 LowStar_Lens_Buffer.reader_t * 'a2 LowStar_Lens_Buffer.reader_t * 'a1 LowStar_Lens_Buffer.writer_t * 'a2 LowStar_Lens_Buffer.writer_t


let uu___is_Mk = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( projectee  :  ('a1, 'p1, 'q1, obj, obj, obj, obj, obj, obj, obj) tup2_t ) -> true)


let __proj__Mk__item__bl1 = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( projectee  :  ('a1, 'p1, 'q1, obj, obj, obj, obj, obj, obj, obj) tup2_t ) -> (match (projectee) with
| Mk (bl1, bl2, read_fst, read_snd, write_fst, write_snd) -> begin
bl1
end))


let __proj__Mk__item__bl2 = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( projectee  :  ('a1, 'p1, 'q1, obj, obj, obj, obj, obj, obj, obj) tup2_t ) -> (match (projectee) with
| Mk (bl1, bl2, read_fst, read_snd, write_fst, write_snd) -> begin
bl2
end))


let __proj__Mk__item__read_fst = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( projectee  :  ('a1, 'p1, 'q1, obj, obj, obj, obj, obj, obj, obj) tup2_t ) -> (match (projectee) with
| Mk (bl1, bl2, read_fst, read_snd, write_fst, write_snd) -> begin
read_fst
end))


let __proj__Mk__item__read_snd = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( projectee  :  ('a1, 'p1, 'q1, obj, obj, obj, obj, obj, obj, obj) tup2_t ) -> (match (projectee) with
| Mk (bl1, bl2, read_fst, read_snd, write_fst, write_snd) -> begin
read_snd
end))


let __proj__Mk__item__write_fst = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( projectee  :  ('a1, 'p1, 'q1, obj, obj, obj, obj, obj, obj, obj) tup2_t ) -> (match (projectee) with
| Mk (bl1, bl2, read_fst, read_snd, write_fst, write_snd) -> begin
write_fst
end))


let __proj__Mk__item__write_snd = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( projectee  :  ('a1, 'p1, 'q1, obj, obj, obj, obj, obj, obj, obj) tup2_t ) -> (match (projectee) with
| Mk (bl1, bl2, read_fst, read_snd, write_fst, write_snd) -> begin
write_snd
end))


let mk_tup2 = (fun ( b1  :  ('a1, 'p1, 'q1) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( a2  :  unit ) ( p2  :  unit ) ( q2  :  unit ) ( b2  :  (obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( bl1  :  ('a1, 'p1, 'q1, obj, obj) LowStar_Lens_Buffer.buffer_lens ) ( bl2  :  (obj, obj, obj, obj, obj) LowStar_Lens_Buffer.buffer_lens ) -> (

let pl = (Prims.unsafe_coerce (mk (LowStar_Lens_Buffer.lens_of b1 f1 bl1) () () (Prims.unsafe_coerce (LowStar_Lens_Buffer.lens_of b2 f2 bl2))))
in (

let l_fst = {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()}
in (

let l_snd = {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()}
in (

let read_fst = (fun ( i  :  LowStar_Lens_Buffer.ix ) -> (

let s = (FStar_HyperStack_ST.get ())
in (LowStar_Lens_Buffer.__proj__Mk__item__reader b1 f1 bl1 s i)))
in (

let read_snd = (fun ( i  :  LowStar_Lens_Buffer.ix ) -> (

let s = (FStar_HyperStack_ST.get ())
in (LowStar_Lens_Buffer.__proj__Mk__item__reader b2 f2 bl2 s i)))
in (

let write_fst = (fun ( i  :  LowStar_Lens_Buffer.ix ) ( v  :  'a1 ) -> (

let s = (FStar_HyperStack_ST.get ())
in (LowStar_Lens_Buffer.__proj__Mk__item__writer b1 f1 bl1 s i v)))
in (

let write_snd = (fun ( i  :  LowStar_Lens_Buffer.ix ) ( v  :  obj ) -> (

let s = (FStar_HyperStack_ST.get ())
in (LowStar_Lens_Buffer.__proj__Mk__item__writer b2 f2 bl2 s i v)))
in Mk (bl1, bl2, read_fst, read_snd, write_fst, write_snd)))))))))


let lens_of = (fun ( uu___4  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( uu___3  :  LowStar_Lens_Buffer.flavor ) ( uu___2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( uu___1  :  LowStar_Lens_Buffer.flavor ) ( uu___  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> ((fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( t  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> (Prims.unsafe_coerce (mk (LowStar_Lens_Buffer.lens_of b1 f1 (__proj__Mk__item__bl1 b1 f1 () () () (Prims.unsafe_coerce b2) (Prims.unsafe_coerce f2) (Prims.unsafe_coerce t))) () () (Prims.unsafe_coerce (LowStar_Lens_Buffer.lens_of b2 f2 (Prims.unsafe_coerce (__proj__Mk__item__bl2 b1 f1 () () () (Prims.unsafe_coerce b2) (Prims.unsafe_coerce f2) (Prims.unsafe_coerce t)))))))) uu___4 uu___3 uu___2 uu___1 uu___))


let l_fst = (fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) -> {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()})


let l_snd = (fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) -> {LowStar_Lens.get = (); LowStar_Lens.put = (); LowStar_Lens.lens_laws = ()})


let read_fst = (fun ( uu___4  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( uu___3  :  LowStar_Lens_Buffer.flavor ) ( uu___2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( uu___1  :  LowStar_Lens_Buffer.flavor ) ( uu___  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> ((fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( t  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> (Prims.unsafe_coerce (__proj__Mk__item__read_fst b1 f1 () () () (Prims.unsafe_coerce b2) (Prims.unsafe_coerce f2) (Prims.unsafe_coerce t)))) uu___4 uu___3 uu___2 uu___1 uu___))


let read_snd = (fun ( uu___4  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( uu___3  :  LowStar_Lens_Buffer.flavor ) ( uu___2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( uu___1  :  LowStar_Lens_Buffer.flavor ) ( uu___  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> ((fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( t  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> (Prims.unsafe_coerce (__proj__Mk__item__read_snd b1 f1 () () () (Prims.unsafe_coerce b2) (Prims.unsafe_coerce f2) (Prims.unsafe_coerce t)))) uu___4 uu___3 uu___2 uu___1 uu___))


let write_fst = (fun ( uu___4  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( uu___3  :  LowStar_Lens_Buffer.flavor ) ( uu___2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( uu___1  :  LowStar_Lens_Buffer.flavor ) ( uu___  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> ((fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( t  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> (Prims.unsafe_coerce (__proj__Mk__item__write_fst b1 f1 () () () (Prims.unsafe_coerce b2) (Prims.unsafe_coerce f2) (Prims.unsafe_coerce t)))) uu___4 uu___3 uu___2 uu___1 uu___))


let write_snd = (fun ( uu___4  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( uu___3  :  LowStar_Lens_Buffer.flavor ) ( uu___2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( uu___1  :  LowStar_Lens_Buffer.flavor ) ( uu___  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> ((fun ( b1  :  ('a, 'b, 'c) LowStar_Monotonic_Buffer.mbuffer ) ( f1  :  LowStar_Lens_Buffer.flavor ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( f2  :  LowStar_Lens_Buffer.flavor ) ( t  :  ('a, 'b, 'c, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> (Prims.unsafe_coerce (__proj__Mk__item__write_snd b1 f1 () () () (Prims.unsafe_coerce b2) (Prims.unsafe_coerce f2) (Prims.unsafe_coerce t)))) uu___4 uu___3 uu___2 uu___1 uu___))


let test_read_ptr_fst = (fun ( b1  :  'a LowStar_Buffer.buffer ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( t  :  ('a, LowStar_Buffer.trivial_preorder, LowStar_Buffer.trivial_preorder, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) -> (read_fst b1 LowStar_Lens_Buffer.Pointer b2 LowStar_Lens_Buffer.Buffer t (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let test_read_buf_snd = (fun ( b1  :  'a LowStar_Buffer.buffer ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( t  :  ('a, LowStar_Buffer.trivial_preorder, LowStar_Buffer.trivial_preorder, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) ( i  :  LowStar_Lens_Buffer.ix ) -> (read_snd b1 LowStar_Lens_Buffer.Pointer b2 LowStar_Lens_Buffer.Buffer t i))


let test_write_ptr_fst = (fun ( b1  :  'a LowStar_Buffer.buffer ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( t  :  ('a, LowStar_Buffer.trivial_preorder, LowStar_Buffer.trivial_preorder, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) ( v  :  'a ) -> (write_fst b1 LowStar_Lens_Buffer.Pointer b2 LowStar_Lens_Buffer.Buffer t (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) v))


let test_write_buf = (fun ( b1  :  'a LowStar_Buffer.buffer ) ( b2  :  ('p, 'q, 'r) LowStar_Monotonic_Buffer.mbuffer ) ( t  :  ('a, LowStar_Buffer.trivial_preorder, LowStar_Buffer.trivial_preorder, obj, obj, 'p, 'q, 'r, obj, obj) tup2_t ) ( i  :  LowStar_Lens_Buffer.ix ) ( v  :  'p ) -> (write_snd b1 LowStar_Lens_Buffer.Pointer b2 LowStar_Lens_Buffer.Buffer t i v))




