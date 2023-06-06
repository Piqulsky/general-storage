package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.Layout;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<View> list_of_views;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        list_of_views = new ArrayList<>();
        Button bt = findViewById(R.id.button);
        Button bt_Enable_BtZ = findViewById(R.id.bt_enable);

        bt.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                LayoutInflater linfl = getLayoutInflater();
                View view = linfl.inflate(R.layout.layout_test_dynamic,null, false);
                list_of_views.add(view);
                LinearLayout lay= findViewById(R.id.lin_lay);
                lay.addView(view);
            }
        });

        bt_Enable_BtZ.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(list_of_views.size() > 0 )
                {
                    for(int i =0; i < list_of_views.size(); i++)
                    {
                        View element = list_of_views.get(i);
                        MainActivity.itemViewHelper el = new itemViewHelper(element);
                        el.get_bt2().setOnClickListener(new View.OnClickListener()
                        {
                            @Override
                            public void onClick(View v) {
                                Toast.makeText(MainActivity.this, "Button Z pressed",
                                        Toast.LENGTH_LONG).show();
                            }
                        });
                    }
                }
            }
        });

    }

    class itemViewHelper
    {
        TextView tv1;
        Button bt1;
        Button bt2;
        itemViewHelper(View v)
        {
            tv1 = v.findViewById(R.id.textView);
            bt1 = v.findViewById(R.id.button2);
            bt2 = v.findViewById(R.id.buttonZ);
        }

        TextView get_tv() {return tv1;}
        TextView get_bt1() {return bt1;}
        TextView get_bt2() {return bt2;}
    }
}