package com.example.listviewcustom;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

public class Adapter extends BaseAdapter
{
    Context _ctx;
    String[] _cnNames;
    int[] _cnFlags;
    //usually when we reuse something quite often we want to initialize it only once
    LayoutInflater inflater;
    //but sometimes this means that we need to write a bit more and make the code unnecessary
    //complex or ugly
    //LayoutInflater _inflater;

    public Adapter(Context ctx, String[] cnNames, int[] cnFlags)
    {
        _ctx = ctx;
        _cnNames = cnNames;
        _cnFlags = cnFlags;
        inflater = LayoutInflater.from(_ctx);
        //_inflater = null;
    }
    @Override
    public int getCount()
    {
        return _cnNames.length;
    }

    @Override
    public Object getItem(int position)
    {
        return null;
    }

    @Override
    public long getItemId(int position)
    {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent)
    {
        //we can to it like below since we get a parent it has to have a context of it's own,
        //we can use that to create the inflater here, but we need to check first if it has already
        //been initialized otherwise all benefit of doing it like that just goes away
        //note the trade of here, we are trading one ctx parameter and rather ugly code for an if
        // statement, and if things got scaled pretty big that if could start matter more
        //if(_inflater == null)
        //    _inflater = LayoutInflater.from(parent.getContext());
        //convertView = _inflater.inflate(R.layout.list_item_layout, null);
        convertView = inflater.inflate(R.layout.list_item_layout, null);

        TextView tv = convertView.findViewById(R.id.textView);
        ImageView img = convertView.findViewById(R.id.imageView);
        tv.setText(_cnNames[position]);
        img.setImageResource(_cnFlags[position]);
        return convertView;
    }
}
