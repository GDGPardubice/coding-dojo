(ns session-20190319.core
  (:gen-class))

(defn merge-sorted-lists
  [list1 list2])

(defn merge-first-rest
  [list1 list2]
  (concat (list(first list1)) (merge-sorted-lists (rest list1) list2)))

(defn merge-sorted-lists
  ([list1 list2]
  (cond
    (empty? list1) list2
    (empty? list2) list1
    :else (if (< (first list1) (first list2)) 
        (merge-first-rest list1 list2)
        (merge-first-rest list2 list1))))
  ([list1 list2 & lists]
    (reduce merge-sorted-lists (merge-sorted-lists list1 list2)  lists )))