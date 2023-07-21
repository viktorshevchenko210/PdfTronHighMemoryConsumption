using pdftron;
using pdftron.PDF;
using pdftron.SDF;

PDFNet.Initialize("demo:1638727123163:7b63556e0300000000e733b5223644478c184cc841cc180fb5c16d6939");

using var fs = File.OpenWrite("..\\net6.0\\1000pages_new.pdf");
using PDFDoc doc = new PDFDoc("..\\net6.0\\1000pages.pdf");


//doc.Save(fs, pdftron.SDF.SDFDoc.SaveOptions.e_compatibility);
doc.Save(fs, SDFDoc.SaveOptions.e_compatibility | SDFDoc.SaveOptions.e_hex_strings);


await Task.Delay(10000); 