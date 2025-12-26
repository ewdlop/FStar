#light "off"
module MerkleTree
type 'dummyV0 mstring =
| Base of Prims.nat
| Concat of Prims.nat * obj mstring * obj mstring


let uu___is_Base : Prims.nat  ->  obj mstring  ->  Prims.bool = (fun ( uu___  :  Prims.nat ) ( projectee  :  obj mstring ) -> (match (projectee) with
| Base (n) -> begin
true
end
| uu___1 -> begin
false
end))


let __proj__Base__item__n : Prims.nat  ->  obj mstring  ->  Prims.nat = (fun ( uu___  :  Prims.nat ) ( projectee  :  obj mstring ) -> (match (projectee) with
| Base (n) -> begin
n
end))


let uu___is_Concat : Prims.nat  ->  obj mstring  ->  Prims.bool = (fun ( uu___  :  Prims.nat ) ( projectee  :  obj mstring ) -> (match (projectee) with
| Concat (n, s1, s2) -> begin
true
end
| uu___1 -> begin
false
end))


let __proj__Concat__item__n : Prims.nat  ->  obj mstring  ->  Prims.nat = (fun ( uu___  :  Prims.nat ) ( projectee  :  obj mstring ) -> (match (projectee) with
| Concat (n, s1, s2) -> begin
n
end))


let __proj__Concat__item__s1 : Prims.nat  ->  obj mstring  ->  obj mstring = (fun ( uu___  :  Prims.nat ) ( projectee  :  obj mstring ) -> (match (projectee) with
| Concat (n, s1, s2) -> begin
s1
end))


let __proj__Concat__item__s2 : Prims.nat  ->  obj mstring  ->  obj mstring = (fun ( uu___  :  Prims.nat ) ( projectee  :  obj mstring ) -> (match (projectee) with
| Concat (n, s1, s2) -> begin
s2
end))


let hash_size : Prims.nat = (Prims.unsafe_coerce (fun ( uu___  :  Prims.nat ) -> (failwith "Not yet implemented: MerkleTree.hash_size")))


let data_size : Prims.nat = (Prims.unsafe_coerce (fun ( uu___  :  Prims.nat ) -> (failwith "Not yet implemented: MerkleTree.data_size")))


type data =
obj mstring


type hash =
obj mstring


let gen_hash : Prims.nat  ->  obj mstring  ->  obj mstring = (fun ( n  :  Prims.nat ) ( uu___  :  obj mstring ) -> (failwith "Not yet implemented: MerkleTree.gen_hash"))


let len = (fun ( uu___  :  unit ) -> FStar_List_Tot_Base.length)

type ('dummyV0, 'dummyV1) mtree =
| L of data
| N of Prims.nat * hash * hash * (obj, obj) mtree * (obj, obj) mtree


let uu___is_L : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  Prims.bool = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| L (data1) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__L__item__data : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  data = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| L (data1) -> begin
data1
end))


let uu___is_N : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  Prims.bool = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| N (n, h1, h2, left, right) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__N__item__n : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  Prims.nat = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| N (n, h1, h2, left, right) -> begin
n
end))


let __proj__N__item__h1 : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  hash = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| N (n, h1, h2, left, right) -> begin
h1
end))


let __proj__N__item__h2 : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  hash = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| N (n, h1, h2, left, right) -> begin
h2
end))


let __proj__N__item__left : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  (obj, obj) mtree = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| N (n, h1, h2, left, right) -> begin
left
end))


let __proj__N__item__right : Prims.nat  ->  hash  ->  (obj, obj) mtree  ->  (obj, obj) mtree = (fun ( uu___  :  Prims.nat ) ( uu___1  :  hash ) ( projectee  :  (obj, obj) mtree ) -> (match (projectee) with
| N (n, h1, h2, left, right) -> begin
right
end))


type path =
Prims.bool Prims.list


let rec get_elt : hash  ->  path  ->  (obj, obj) mtree  ->  data = (fun ( h  :  hash ) ( path1  :  path ) ( tree  :  (obj, obj) mtree ) -> (match (path1) with
| [] -> begin
(__proj__L__item__data ((len ()) path1) h tree)
end
| (bit)::path' -> begin
(match (bit) with
| true -> begin
(get_elt (__proj__N__item__h1 ((len ()) path1) h tree) path' (__proj__N__item__left ((len ()) path1) h tree))
end
| uu___ -> begin
(get_elt (__proj__N__item__h2 ((len ()) path1) h tree) path' (__proj__N__item__right ((len ()) path1) h tree))
end)
end))

type proof =
| Mk_proof of data * hash Prims.list


let uu___is_Mk_proof : proof  ->  Prims.bool = (fun ( projectee  :  proof ) -> true)


let __proj__Mk_proof__item__data : proof  ->  data = (fun ( projectee  :  proof ) -> (match (projectee) with
| Mk_proof (data1, pstream) -> begin
data1
end))


let __proj__Mk_proof__item__pstream : proof  ->  hash Prims.list = (fun ( projectee  :  proof ) -> (match (projectee) with
| Mk_proof (data1, pstream) -> begin
pstream
end))


let lenp : proof  ->  Prims.nat = (fun ( p  :  proof ) -> ((len ()) (__proj__Mk_proof__item__pstream p)))


let p_tail : proof  ->  proof = (fun ( p  :  proof ) -> Mk_proof ((__proj__Mk_proof__item__data p), (Prims.__proj__Cons__item__tl (__proj__Mk_proof__item__pstream p))))


let p_data : proof  ->  data = __proj__Mk_proof__item__data


let p_stream : proof  ->  hash Prims.list = __proj__Mk_proof__item__pstream


let rec verifier : path  ->  proof  ->  hash = (fun ( path1  :  path ) ( p  :  proof ) -> (match (path1) with
| [] -> begin
(gen_hash data_size (p_data p))
end
| (bit)::path' -> begin
(match ((p_stream p)) with
| (hd)::uu___ -> begin
(

let h' = (verifier path' (p_tail p))
in (match (bit) with
| true -> begin
(gen_hash (hash_size + hash_size) (Concat (hash_size, h', hd)))
end
| uu___1 -> begin
(gen_hash (hash_size + hash_size) (Concat (hash_size, hd, h')))
end))
end)
end))


let rec prover : hash  ->  path  ->  (obj, obj) mtree  ->  proof = (fun ( h  :  hash ) ( path1  :  path ) ( tree  :  (obj, obj) mtree ) -> (match (path1) with
| [] -> begin
Mk_proof ((__proj__L__item__data ((len ()) path1) h tree), [])
end
| (bit)::path' -> begin
(

let uu___ = tree
in (match (uu___) with
| N (dc, hl, hr, left, right) -> begin
(match (bit) with
| true -> begin
(

let p = (prover hl path' left)
in Mk_proof ((p_data p), (hr)::(p_stream p)))
end
| uu___1 -> begin
(

let p = (prover hr path' right)
in Mk_proof ((p_data p), (hl)::(p_stream p)))
end)
end))
end))


type hash_collision =
(Prims.nat, (obj mstring, (obj mstring, unit) FStar_Constructive.cexists) FStar_Constructive.cexists) FStar_Constructive.cexists


let rec security : hash  ->  path  ->  (obj, obj) mtree  ->  proof  ->  hash_collision = (fun ( h  :  hash ) ( path1  :  path ) ( tree  :  (obj, obj) mtree ) ( p  :  proof ) -> (match (path1) with
| [] -> begin
FStar_Constructive.ExIntro (data_size, FStar_Constructive.ExIntro ((p_data p), FStar_Constructive.ExIntro ((__proj__L__item__data ((len ()) path1) h tree), ())))
end
| (bit)::path' -> begin
(

let uu___ = tree
in (match (uu___) with
| N (dc, h1, h2, left, right) -> begin
(

let h' = (verifier path' (p_tail p))
in (

let hd = (Prims.__proj__Cons__item__hd (p_stream p))
in (match (bit) with
| true -> begin
(match ((Prims.op_Equality h' h1)) with
| true -> begin
(security h1 path' left (p_tail p))
end
| uu___1 -> begin
FStar_Constructive.ExIntro ((hash_size + hash_size), FStar_Constructive.ExIntro (Concat (hash_size, h1, h2), FStar_Constructive.ExIntro (Concat (hash_size, h', hd), ())))
end)
end
| uu___1 -> begin
(match ((Prims.op_Equality h' h2)) with
| true -> begin
(security h2 path' right (p_tail p))
end
| uu___2 -> begin
FStar_Constructive.ExIntro ((hash_size + hash_size), FStar_Constructive.ExIntro (Concat (hash_size, h1, h2), FStar_Constructive.ExIntro (Concat (hash_size, hd, h'), ())))
end)
end)))
end))
end))




