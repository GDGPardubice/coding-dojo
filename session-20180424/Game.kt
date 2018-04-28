import java.lang.IndexOutOfBoundsException

class Game {
    var plan: GamePlan? = null
    var pacmanPosition: Position? = null
        set(value) {
            if(plan == null || value == null || plan!!.width <= value.x || plan!!.height <= value.y){
                throw IndexOutOfBoundsException()
            }
            field = value
        }

    fun isReady(): Boolean {
        return plan != null && pacmanPosition != null
    }

}
