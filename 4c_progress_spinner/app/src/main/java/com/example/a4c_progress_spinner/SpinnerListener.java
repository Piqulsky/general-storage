package com.example.a4c_progress_spinner;

import android.view.View;
import android.widget.AdapterView;
import android.widget.ProgressBar;

public class SpinnerListener implements AdapterView.OnItemSelectedListener {
    private ProgressBar progressBar;
    public SpinnerListener(ProgressBar progressBar){
        this.progressBar = progressBar;
    }
    public void onItemSelected(AdapterView<?> parent, View view, int pos, long id) {
        String item = parent.getSelectedItem().toString();
        progressBar.setProgress(Integer.parseInt(item));
    }

    public void onNothingSelected(AdapterView<?> parent) {
        // Another interface callback
    }
}
