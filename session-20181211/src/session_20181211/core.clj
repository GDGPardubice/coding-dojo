(ns session-20181211.core
  (:gen-class))

(defn neighbours [x y]
  (list 
    [(+ x 1) (+ y 1)] 
    [x (+ y 1)] 
    [(+ x 1) y]
    [(- x 1) (+ y 1)]
    [(- x 1) (- y 1)] 
    [x (- y 1)] 
    [(- x 1) y]
    [(+ x 1) (- y 1)]
  )
)

(defn mines-count
  [mines x y]
    (count (filter #(contains? mines %1) (neighbours x y)))
)


