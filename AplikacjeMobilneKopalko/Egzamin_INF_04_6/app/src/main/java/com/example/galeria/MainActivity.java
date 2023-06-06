package com.example.galeria;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.Switch;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        imageBox = (ImageView) findViewById(R.id.imageBox);
        numberInput = (EditText) findViewById(R.id.imageNumberInput);
        backgroundSwitch = (Switch) findViewById(R.id.backgroundSwitch);
        layout = (LinearLayout) findViewById(R.id.mainLayout);

        numberInput.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                return;
            }

            /***********************************************
             nazwa funkcji: onTextChanged
             argumenty: CharSequence charSequence
                        int i,
                        int i1,
                        int i2
             typ zwracany: void
             informacje: funkcja obsługująca zmianę wartości pola do wpisywania liczby
             autor: Bastian Wierzchnicki
             ****************************************************/

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                try {
                    int number = Integer.parseInt(charSequence.toString()) - 1;
                    if(number >= 0 || number <= (images.length - 1)) {
                        currentPos = number;
                        imageBox.setImageResource(images[currentPos]);
                    }
                } catch(Exception e) {
                    return;
                }
            }

            @Override
            public void afterTextChanged(Editable editable) {
                return;
            }
        });

        backgroundSwitch.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {

            /***********************************************
             nazwa funkcji: onCheckedChanged
             argumenty: CompoundButton compoundButton
                        boolean b
             typ zwracany: void
             informacje: funkcja obsługująca zmianę wartości switcha
             autor: Bastian Wierzchnicki
             ****************************************************/

            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
                if(backgroundSwitch.isChecked()) {
                    layout.setBackgroundColor(Color.parseColor("#1565c0"));
                } else layout.setBackgroundColor(Color.parseColor("#00796B"));
            }
        });

    }

    ImageView imageBox;
    EditText numberInput;
    Switch backgroundSwitch;
    LinearLayout layout;
    int currentPos = 0;
    int[] images = { R.drawable.kot1, R.drawable.kot2, R.drawable.kot3, R.drawable.kot4 };

   /***********************************************
    nazwa funkcji: onPrevClick
    argumenty: View view - widok aplikacji
    typ zwracany: void
    informacje: funkcja zmienia obrazek na wcześniejszy
    autor: Bastian Wierzchnicki
    ****************************************************/

    public void onPrevClick(View view) {
        if(currentPos == 0) {
            currentPos = images.length - 1;
        }
        else { currentPos--; };
        imageBox.setImageResource(images[currentPos]);
    }

    /***********************************************
     nazwa funkcji: onNextClick
     argumenty: View view - widok aplikacji
     typ zwracany: void
     informacje: funkcja zmienia obrazek na następny
     autor: Bastian Wierzchnicki
     ****************************************************/

    public void onNextClick(View view) {
        if(currentPos == (images.length - 1)) {
            currentPos = 0;
        }
        else { currentPos++; };
        imageBox.setImageResource(images[currentPos]);
    }
}