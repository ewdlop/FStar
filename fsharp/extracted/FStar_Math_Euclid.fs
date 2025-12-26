#light "off"
module FStar_Math_Euclid

type divides =
unit


type is_gcd =
unit


let rec egcd : Prims.int  ->  Prims.int  ->  Prims.int  ->  Prims.int  ->  Prims.int  ->  Prims.int  ->  Prims.int  ->  Prims.int  ->  (Prims.int * Prims.int * Prims.int) = (fun ( a  :  Prims.int ) ( b  :  Prims.int ) ( u1  :  Prims.int ) ( u2  :  Prims.int ) ( u3  :  Prims.int ) ( v1  :  Prims.int ) ( v2  :  Prims.int ) ( v3  :  Prims.int ) -> (match ((Prims.op_Equality v3 (Prims.parse_int "0"))) with
| true -> begin
((u1), (u2), (u3))
end
| uu___ -> begin
(

let q = (u3 / v3)
in (

let uu___1 = ((v1), ((u1 - (q * v1))))
in (match (uu___1) with
| (u11, v11) -> begin
(

let uu___2 = ((v2), ((u2 - (q * v2))))
in (match (uu___2) with
| (u21, v21) -> begin
(

let u3' = u3
in (

let v3' = v3
in (

let uu___3 = ((v3), ((u3 - (q * v3))))
in (match (uu___3) with
| (u31, v31) -> begin
(

let r = (egcd a b u11 u21 u31 v11 v21 v31)
in r)
end))))
end))
end)))
end))


let euclid_gcd : Prims.int  ->  Prims.int  ->  (Prims.int * Prims.int * Prims.int) = (fun ( a  :  Prims.int ) ( b  :  Prims.int ) -> (match ((b >= (Prims.parse_int "0"))) with
| true -> begin
(egcd a b (Prims.parse_int "1") (Prims.parse_int "0") a (Prims.parse_int "0") (Prims.parse_int "1") b)
end
| uu___ -> begin
(

let res = (egcd a b (Prims.parse_int "1") (Prims.parse_int "0") a (Prims.parse_int "0") (Prims.parse_int "-1") (- (b)))
in (

let uu___1 = res
in (match (uu___1) with
| (uu___2, uu___3, d) -> begin
res
end)))
end))


type is_prime =
unit


let bezout_prime : Prims.int  ->  Prims.pos  ->  (Prims.int * Prims.int) = (fun ( p  :  Prims.int ) ( a  :  Prims.pos ) -> (

let uu___ = (euclid_gcd p a)
in (match (uu___) with
| (r, s, d) -> begin
(match ((Prims.op_Equality d (Prims.parse_int "1"))) with
| true -> begin
((r), (s))
end
| uu___1 -> begin
(((- (r))), ((- (s))))
end)
end)))




