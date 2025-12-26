#light "off"
module Huffman

type symbol =
FStar_Char.char

type trie =
| Leaf of Prims.pos * symbol
| Node of Prims.pos * trie * trie


let uu___is_Leaf : trie  ->  Prims.bool = (fun ( projectee  :  trie ) -> (match (projectee) with
| Leaf (w, s) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Leaf__item__w : trie  ->  Prims.pos = (fun ( projectee  :  trie ) -> (match (projectee) with
| Leaf (w, s) -> begin
w
end))


let __proj__Leaf__item__s : trie  ->  symbol = (fun ( projectee  :  trie ) -> (match (projectee) with
| Leaf (w, s) -> begin
s
end))


let uu___is_Node : trie  ->  Prims.bool = (fun ( projectee  :  trie ) -> (match (projectee) with
| Node (w, l, r) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Node__item__w : trie  ->  Prims.pos = (fun ( projectee  :  trie ) -> (match (projectee) with
| Node (w, l, r) -> begin
w
end))


let __proj__Node__item__l : trie  ->  trie = (fun ( projectee  :  trie ) -> (match (projectee) with
| Node (w, l, r) -> begin
l
end))


let __proj__Node__item__r : trie  ->  trie = (fun ( projectee  :  trie ) -> (match (projectee) with
| Node (w, l, r) -> begin
r
end))


let weight : trie  ->  Prims.pos = (fun ( t  :  trie ) -> (match (t) with
| Leaf (w, uu___) -> begin
w
end
| Node (w, uu___, uu___1) -> begin
w
end))


let leq_trie : trie  ->  trie  ->  Prims.bool = (fun ( t1  :  trie ) ( t2  :  trie ) -> ((weight t1) <= (weight t2)))


let rec sorted : trie Prims.list  ->  Prims.bool = (fun ( ts  :  trie Prims.list ) -> (match (ts) with
| [] -> begin
true
end
| (uu___)::[] -> begin
true
end
| (t1)::(t2)::ts' -> begin
((leq_trie t1 t2) && (sorted ((t2)::ts')))
end))


type permutation =
unit


let rec insert_in_sorted : trie  ->  trie Prims.list  ->  trie Prims.list = (fun ( x  :  trie ) ( xs  :  trie Prims.list ) -> (match (xs) with
| [] -> begin
(x)::[]
end
| (x')::xs' -> begin
(match ((leq_trie x x')) with
| true -> begin
(x)::xs
end
| uu___ -> begin
(

let i_tl = (insert_in_sorted x xs')
in (

let uu___1 = i_tl
in (match (uu___1) with
| (z)::uu___2 -> begin
(x')::i_tl
end)))
end)
end))


let rec insertion_sort : trie Prims.list  ->  trie Prims.list = (fun ( ts  :  trie Prims.list ) -> (match (ts) with
| [] -> begin
[]
end
| (t)::ts' -> begin
(insert_in_sorted t (insertion_sort ts'))
end))


let rec huffman_trie : trie Prims.list  ->  trie = (fun ( ts  :  trie Prims.list ) -> (match (ts) with
| (t1)::(t2)::ts' -> begin
(

let w = ((weight t1) + (weight t2))
in (

let t = (huffman_trie (insert_in_sorted (Node (w, t1, t2)) ts'))
in t))
end
| (t1)::[] -> begin
t1
end))


let huffman : (symbol * Prims.pos) Prims.list  ->  trie = (fun ( sws  :  (symbol * Prims.pos) Prims.list ) -> (huffman_trie (insertion_sort (FStar_List_Tot_Base.map (fun ( uu___  :  (symbol * Prims.pos) ) -> (match (uu___) with
| (s, w) -> begin
Leaf (w, s)
end)) sws))))


let rec encode_one : trie  ->  symbol  ->  Prims.bool Prims.list FStar_Pervasives_Native.option = (fun ( t  :  trie ) ( s  :  symbol ) -> (match (t) with
| Leaf (uu___, s') -> begin
(match ((Prims.op_Equality s s')) with
| true -> begin
FStar_Pervasives_Native.Some ([])
end
| uu___1 -> begin
FStar_Pervasives_Native.None
end)
end
| Node (uu___, t1, t2) -> begin
(match ((encode_one t1 s)) with
| FStar_Pervasives_Native.Some (bs) -> begin
FStar_Pervasives_Native.Some ((false)::bs)
end
| FStar_Pervasives_Native.None -> begin
(match ((encode_one t2 s)) with
| FStar_Pervasives_Native.Some (bs) -> begin
FStar_Pervasives_Native.Some ((true)::bs)
end
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.None
end)
end)
end))


let rec encode : trie  ->  symbol Prims.list  ->  Prims.bool Prims.list FStar_Pervasives_Native.option = (fun ( t  :  trie ) ( ss  :  symbol Prims.list ) -> (match (ss) with
| [] -> begin
FStar_Pervasives_Native.None
end
| (s)::[] -> begin
(encode_one t s)
end
| (s)::ss' -> begin
(match ((((encode_one t s)), ((encode t ss')))) with
| (FStar_Pervasives_Native.Some (bs), FStar_Pervasives_Native.Some (bs')) -> begin
FStar_Pervasives_Native.Some ((FStar_List_Tot_Base.op_At bs bs'))
end
| (uu___, uu___1) -> begin
FStar_Pervasives_Native.None
end)
end))


let rec decode_one : trie  ->  Prims.bool Prims.list  ->  (symbol * Prims.bool Prims.list) FStar_Pervasives_Native.option = (fun ( t  :  trie ) ( bs  :  Prims.bool Prims.list ) -> (match (((t), (bs))) with
| (Node (uu___, t1, t2), (b)::bs') -> begin
(decode_one (match (b) with
| true -> begin
t2
end
| uu___1 -> begin
t1
end) bs')
end
| (Leaf (uu___, s), uu___1) -> begin
FStar_Pervasives_Native.Some (((s), (bs)))
end
| (Node (uu___, uu___1, uu___2), []) -> begin
FStar_Pervasives_Native.None
end))


let rec decode' : trie  ->  Prims.bool Prims.list  ->  symbol Prims.list FStar_Pervasives_Native.option = (fun ( t  :  trie ) ( bs  :  Prims.bool Prims.list ) -> (match (((t), (bs))) with
| (Leaf (uu___, s), []) -> begin
FStar_Pervasives_Native.Some ((s)::[])
end
| (Leaf (uu___, uu___1), (uu___2)::uu___3) -> begin
FStar_Pervasives_Native.None
end
| (Node (uu___, uu___1, uu___2), []) -> begin
FStar_Pervasives_Native.Some ([])
end
| (Node (uu___, uu___1, uu___2), (uu___3)::uu___4) -> begin
(match ((decode_one t bs)) with
| FStar_Pervasives_Native.Some (s, bs') -> begin
(match ((decode' t bs')) with
| FStar_Pervasives_Native.Some (ss) -> begin
FStar_Pervasives_Native.Some ((s)::ss)
end
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.None
end)
end
| uu___5 -> begin
FStar_Pervasives_Native.None
end)
end))


let rec decode_aux : trie  ->  trie  ->  Prims.bool Prims.list  ->  symbol Prims.list FStar_Pervasives_Native.option = (fun ( t'  :  trie ) ( t  :  trie ) ( bs  :  Prims.bool Prims.list ) -> (match (((t), (bs))) with
| (Leaf (uu___, s), []) -> begin
FStar_Pervasives_Native.Some ((s)::[])
end
| (Leaf (uu___, s), (uu___1)::uu___2) -> begin
(match ((decode_aux t' t' bs)) with
| FStar_Pervasives_Native.Some (ss) -> begin
FStar_Pervasives_Native.Some ((s)::ss)
end
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.None
end)
end
| (Node (uu___, t1, t2), (b)::bs') -> begin
(decode_aux t' (match (b) with
| true -> begin
t2
end
| uu___1 -> begin
t1
end) bs')
end
| (Node (uu___, uu___1, uu___2), []) -> begin
FStar_Pervasives_Native.None
end))


let decode : trie  ->  Prims.bool Prims.list  ->  symbol Prims.list FStar_Pervasives_Native.option = (fun ( t  :  trie ) ( bs  :  Prims.bool Prims.list ) -> (decode_aux t t bs))




