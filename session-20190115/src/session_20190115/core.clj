(ns session-20190115.core
  (:gen-class))

(defn next-state-scorer [scorer oponent]
  (cond (= scorer :advantage) :win
        (= scorer 40) (if (= oponent 40) :advantage (if (= oponent :advantage) 40 :win))
        (= scorer 30) 40
        :else (+ scorer 15)))

(defn next-state-oponent [oponent]
  (if (= oponent :advantage) 40 oponent))

(defn next-score
  [[first second] scorer]
  (if (= scorer :first)
    [(next-state-scorer first second) (next-state-oponent second)]
    [(next-state-oponent first) (next-state-scorer second first)]))
