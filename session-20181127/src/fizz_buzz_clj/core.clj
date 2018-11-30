(ns fizz-buzz-clj.core
  (:gen-class))

(defn generic-convert
  [fizz buzz number]
  (cond
    (= (mod number (* buzz fizz)) 0) :fizzbuzz
    (= (mod number fizz) 0) :fizz
    (= (mod number buzz) 0) :buzz
    :else number))

(defn convert
  [number]
  (generic-convert 3 5 number))

(defn fizz-buzz
  []
  (map convert (range 1 100)))
