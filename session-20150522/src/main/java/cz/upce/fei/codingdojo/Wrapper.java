package cz.upce.fei.codingdojo;

/**
 * Created by Emil on 22. 5. 2015.
 */
public class Wrapper {

    public static String wrapText(String text, int columnNumber) {
        StringBuffer s = new StringBuffer();
        int textLength = text.length();

        for (int i = 0; i < textLength; i+=columnNumber) {
            if(s.length() > 0) s.append("\n");
            String toAppend = text.substring(i, Math.min(i + columnNumber, textLength));
            s.append(toAppend);
        }
        return s.toString();
    }

}
