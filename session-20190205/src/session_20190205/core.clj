(ns session-20190205.core
  (:gen-class))


(defn next-action [step]
  (cond (= step :IMPLEMENT) :REFACTOR
        (= step :REFACTOR) :RED-TEST
        :else :IMPLEMENT))

(defn next-step [[programmer step] [programmer1 programmer2]]

  (def next-action-state (next-action step))
  (if (= step :RED-TEST) 
    (if (= programmer programmer2) 
      [programmer1 next-action-state] 
      [programmer2 next-action-state]) 
    [programmer next-action-state]
    ))
