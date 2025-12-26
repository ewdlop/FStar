#light "off"
module FStar_Relational_Relational
type ('a, 'b) rel =
| R of 'a * 'b


let uu___is_R = (fun ( projectee  :  ('a, 'b) rel ) -> true)


let __proj__R__item__l = (fun ( projectee  :  ('a, 'b) rel ) -> (match (projectee) with
| R (l, r) -> begin
l
end))


let __proj__R__item__r = (fun ( projectee  :  ('a, 'b) rel ) -> (match (projectee) with
| R (l, r) -> begin
r
end))


type 't double =
('t, 't) rel


type 't eq =
't double


let twice = (fun ( x  :  'uuuuu ) -> R (x, x))


let tu : (unit, unit) rel = (twice ())


let rel_map1T = (fun ( f  :  'a  ->  'b ) ( uu___  :  'a double ) -> (match (uu___) with
| R (x1, x2) -> begin
R ((f x1), (f x2))
end))


let rel_map2Teq = (fun ( f  :  'a  ->  'b  ->  'c ) ( uu___  :  'a double ) ( uu___1  :  'b double ) -> (match (((uu___), (uu___1))) with
| (R (x1, x2), R (y1, y2)) -> begin
R ((f x1 y1), (f x2 y2))
end))


let rel_map2T = (fun ( f  :  'a  ->  'b  ->  'c ) ( uu___  :  'a double ) ( uu___1  :  'b double ) -> (match (((uu___), (uu___1))) with
| (R (x1, x2), R (y1, y2)) -> begin
R ((f x1 y1), (f x2 y2))
end))


let rel_map3T = (fun ( f  :  'a  ->  'b  ->  'c  ->  'd ) ( uu___  :  'a double ) ( uu___1  :  'b double ) ( uu___2  :  'c double ) -> (match (((uu___), (uu___1), (uu___2))) with
| (R (x1, x2), R (y1, y2), R (z1, z2)) -> begin
R ((f x1 y1 z1), (f x2 y2 z2))
end))


let op_Hat_Plus : Prims.int double  ->  Prims.int double  ->  Prims.int double = (rel_map2T (fun ( x  :  Prims.int ) ( y  :  Prims.int ) -> (x + y)))


let op_Hat_Minus : Prims.int double  ->  Prims.int double  ->  Prims.int double = (rel_map2T (fun ( x  :  Prims.int ) ( y  :  Prims.int ) -> (x - y)))


let op_Hat_Star : Prims.int double  ->  Prims.int double  ->  Prims.int double = (rel_map2T (fun ( x  :  Prims.int ) ( y  :  Prims.int ) -> (x * y)))


let op_Hat_Slash : Prims.int double  ->  Prims.nonzero double  ->  Prims.int double = (rel_map2T (fun ( x  :  Prims.int ) ( y  :  Prims.nonzero ) -> (x / y)))


let tl_rel = (fun ( uu___  :  'a Prims.list double ) -> (match (uu___) with
| R ((uu___1)::xs, (uu___2)::ys) -> begin
R (xs, ys)
end))


let cons_rel = (fun ( uu___  :  ('uuuuu, 'uuuuu1) rel ) ( uu___1  :  ('uuuuu Prims.list, 'uuuuu1 Prims.list) rel ) -> (match (((uu___), (uu___1))) with
| (R (x, y), R (xs, ys)) -> begin
R ((x)::xs, (y)::ys)
end))


let pair_rel = (fun ( uu___  :  ('uuuuu, 'uuuuu1) rel ) ( uu___1  :  ('uuuuu2, 'uuuuu3) rel ) -> (match (((uu___), (uu___1))) with
| (R (a, b), R (c, d)) -> begin
R (((a), (c)), ((b), (d)))
end))


let triple_rel = (fun ( uu___  :  ('uuuuu, 'uuuuu1) rel ) ( uu___1  :  ('uuuuu2, 'uuuuu3) rel ) ( uu___2  :  ('uuuuu4, 'uuuuu5) rel ) -> (match (((uu___), (uu___1), (uu___2))) with
| (R (a, b), R (c, d), R (e, f)) -> begin
R (((a), (c), (e)), ((b), (d), (f)))
end))


let fst_rel = (fun ( uu___  :  unit ) -> (rel_map1T FStar_Pervasives_Native.fst))


let snd_rel = (fun ( uu___  :  unit ) -> (rel_map1T FStar_Pervasives_Native.snd))


let and_rel : Prims.bool double  ->  Prims.bool double  ->  Prims.bool double = (rel_map2T (fun ( x  :  Prims.bool ) ( y  :  Prims.bool ) -> (x && y)))


let or_rel : Prims.bool double  ->  Prims.bool double  ->  Prims.bool double = (rel_map2T (fun ( x  :  Prims.bool ) ( y  :  Prims.bool ) -> (x || y)))


let eq_rel : Prims.bool double  ->  Prims.bool double  ->  Prims.bool double = (rel_map2Teq (fun ( x  :  Prims.bool ) ( y  :  Prims.bool ) -> (Prims.op_Equality x y)))


let and_irel : (Prims.bool, Prims.bool) rel  ->  Prims.bool = (fun ( uu___  :  (Prims.bool, Prims.bool) rel ) -> (match (uu___) with
| R (a, b) -> begin
(a && b)
end))


let or_irel : (Prims.bool, Prims.bool) rel  ->  Prims.bool = (fun ( uu___  :  (Prims.bool, Prims.bool) rel ) -> (match (uu___) with
| R (a, b) -> begin
(a || b)
end))


let eq_irel = (fun ( x  :  ('t, 't) rel ) -> (match (x) with
| R (a, b) -> begin
(Prims.op_Equality a b)
end))




