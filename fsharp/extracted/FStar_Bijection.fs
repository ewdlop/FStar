#light "off"
module FStar_Bijection
type ('a, 'b) bijection =
{right : 'a  ->  'b; left : 'b  ->  'a; left_right : unit; right_left : unit}


let __proj__Mkbijection__item__right = (fun ( projectee  :  ('a, 'b) bijection ) -> (match (projectee) with
| {right = right; left = left; left_right = left_right; right_left = right_left} -> begin
right
end))


let __proj__Mkbijection__item__left = (fun ( projectee  :  ('a, 'b) bijection ) -> (match (projectee) with
| {right = right; left = left; left_right = left_right; right_left = right_left} -> begin
left
end))


type ('a, 'b) op_Equals_Tilde =
('a, 'b) bijection


let mk_bijection = (fun ( right  :  'a  ->  'b ) ( left  :  'b  ->  'a ) ( right_left  :  unit ) ( left_right  :  unit ) -> {right = right; left = left; left_right = (); right_left = ()})


let op_Greater_Greater = (fun ( x  :  'a ) ( bij  :  ('a, 'b) op_Equals_Tilde ) -> (bij.right x))


let op_Less_Less = (fun ( x  :  'b ) ( bij  :  ('a, 'b) op_Equals_Tilde ) -> (bij.left x))


let bij_self = (fun ( uu___  :  unit ) -> {right = (fun ( x  :  'a ) -> x); left = (fun ( x  :  'a ) -> x); left_right = (); right_left = ()})


let bij_sym = (fun ( d  :  ('a, 'b) op_Equals_Tilde ) -> {right = d.left; left = d.right; left_right = (); right_left = ()})


let o = (fun ( f  :  'uuuuu  ->  'uuuuu1 ) ( g  :  'uuuuu2  ->  'uuuuu ) ( x  :  'uuuuu2 ) -> (f (g x)))


let bij_comp = (fun ( ab  :  ('a, 'b) op_Equals_Tilde ) ( bc  :  ('b, 'c) op_Equals_Tilde ) -> {right = (o bc.right ab.right); left = (o ab.left bc.left); left_right = (); right_left = ()})


let bij_flip_prod = (fun ( uu___  :  unit ) -> {right = (fun ( uu___1  :  ('a * 'b) ) -> (match (uu___1) with
| (x, y) -> begin
((y), (x))
end)); left = (fun ( uu___1  :  ('b * 'a) ) -> (match (uu___1) with
| (y, x) -> begin
((x), (y))
end)); left_right = (); right_left = ()})


let bij_prod = (fun ( ab  :  ('a, 'b) op_Equals_Tilde ) ( cd  :  ('c, 'd) op_Equals_Tilde ) -> {right = (fun ( uu___  :  ('a * 'c) ) -> (match (uu___) with
| (x, y) -> begin
(((ab.right x)), ((cd.right y)))
end)); left = (fun ( uu___  :  ('b * 'd) ) -> (match (uu___) with
| (x, y) -> begin
(((ab.left x)), ((cd.left y)))
end)); left_right = (); right_left = ()})


let bij_either = (fun ( ab  :  ('a, 'b) op_Equals_Tilde ) ( cd  :  ('c, 'd) op_Equals_Tilde ) -> {right = (fun ( x  :  ('a, 'c) FStar_Pervasives.either ) -> (match (x) with
| FStar_Pervasives.Inl (x1) -> begin
FStar_Pervasives.Inl ((ab.right x1))
end
| FStar_Pervasives.Inr (y) -> begin
FStar_Pervasives.Inr ((cd.right y))
end)); left = (fun ( x  :  ('b, 'd) FStar_Pervasives.either ) -> (match (x) with
| FStar_Pervasives.Inl (x1) -> begin
FStar_Pervasives.Inl ((ab.left x1))
end
| FStar_Pervasives.Inr (y) -> begin
FStar_Pervasives.Inr ((cd.left y))
end)); left_right = (); right_left = ()})


let bij_flip_sum = (fun ( uu___  :  unit ) -> {right = (fun ( uu___1  :  ('a, 'b) FStar_Pervasives.either ) -> (match (uu___1) with
| FStar_Pervasives.Inl (x) -> begin
FStar_Pervasives.Inr (x)
end
| FStar_Pervasives.Inr (y) -> begin
FStar_Pervasives.Inl (y)
end)); left = (fun ( uu___1  :  ('b, 'a) FStar_Pervasives.either ) -> (match (uu___1) with
| FStar_Pervasives.Inl (x) -> begin
FStar_Pervasives.Inr (x)
end
| FStar_Pervasives.Inr (y) -> begin
FStar_Pervasives.Inl (y)
end)); left_right = (); right_left = ()})




