(ns session-20190226.core
  (:gen-class))

(defn vec-to-map [array]
  (zipmap array (range (count array))))

(defn two-sum [array target]
  (def value-index-map (vec-to-map array))
  (loop [[current & rest] array]
    (def diff (- target current))
    (def second-position (get value-index-map diff))
    (if (= second-position nil) 
      (recur rest) 
      [(get value-index-map current) second-position]))
    )