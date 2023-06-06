    package com.example.listviewexample;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.util.ArrayList;

//Prerequisites
    //Need to have an xml file that holds a TextView item that
    //will be used by the adapter to represent the string from the items list
    public class MainActivity extends AppCompatActivity
{
    //this is the list that will hold the String data
    ArrayList<String> items;
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        //in order to use the list we need to create it first (it's a dynamic type after all)
        items = new ArrayList<>();
        //and populate the list with the items that need to be show in the list
        // at the start of the app
        items.add("Ala"); items.add("ma");  items.add("Kota");
        items.add("a");   items.add("Kot"); items.add("ma");
        setContentView(R.layout.activity_main);

        //let's create a local ListView variable to hold the reference to the ListView that is
        //going to be created with the xml (activity_main.xml to be precise)
        ListView lv = findViewById(R.id.itemsList);
        //the same goes here for the button that we have on the main screen
        Button bt = findViewById(R.id.button);
        //now let's create an Adapter, since we are using an array to hold the data we can use
        //inbuilt adapter type called array Adapter, we need to provide it with :
        //activity context, here it's this since we are doing it on behalf of the main activity
        //which code we are actually creating right now
        //next we need to provide the layout file that holds the representation of list's item
        //that means we need to create additional layout file that holds one TextView
        //next we need to provide the actual TextView's id on said xml layout, and last but not least
        //we need to point to the array that holding the items
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this,R.layout.list_item,R.id.TextView_,items);
        //tell the ListView instance to use our newly minted adapter
        lv.setAdapter(adapter);
        //create action on button click
        bt.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v)
            {
                //get the text from the box
                //add it to the list we are using to hold the list items
                EditText et = findViewById(R.id.toDoItem);
                items.add(et.getText().toString());
                //and notify the adapter that we have just updated it's data source
                adapter.notifyDataSetChanged();
            }
        });

    }
}