package pl.edu.sci.a4c_progress_spinner;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import android.content.Context;
import android.content.res.Resources;
import android.graphics.Rect;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.CompoundButton;
import android.widget.ProgressBar;
import android.widget.SeekBar;
import android.widget.Spinner;
import android.widget.Switch;

public class MainActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Spinner spinner = findViewById(R.id.spinner);
        ProgressBar progressBar = findViewById(R.id.progressBar);
        Switch toggle = findViewById(R.id.switch1);
        Drawable progressDrawable = progressBar.getProgressDrawable();
        SeekBar seekBar = findViewById(R.id.seekBar);

        //this is one of the handlers or listeners as Android calls them for Spinner
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                int progressValue = Integer.parseInt(adapterView.getSelectedItem().toString());
                progressBar.setProgress(progressValue);
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

        toggle.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener()
        {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked)
            {
                if (isChecked)
                {

                    int currPogress = progressBar.getProgress();
                    Drawable dr = ContextCompat.getDrawable(getApplicationContext(), R.drawable.custom_progress);
                    progressBar.setProgressDrawable(dr);
                    progressBar.setProgress(0);
                    progressBar.setProgress(currPogress);
                }
                else
                {
                    progressBar.setProgressDrawable(progressDrawable);
                }
            }
        });
        seekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                progressBar.setProgress(progress);
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });


    }
}