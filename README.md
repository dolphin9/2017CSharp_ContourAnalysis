# Contour Analysis
### 2017 summer term  C# Homework

&copy; dolphin9  11th Sep. 2017

####  Some Materials About CA
> ##### What is Necessary for the Contour Analysis
> The CA allows to describe, store, compare and find the objects presented in the form of the exterior outlines - contours.
>
>CA allows to effectively solve the main problems of a pattern recognition - transposition, turn and a rescaling of the image of object. CA methods are invariant to these transformations.
> ##### The Main Concepts
>
>we define such an object contour. The contour is a boundary of object, a population of points (pixels), separating object from a background.
>in a CA the contour is encoded by the sequence consisting of complex numbers. On a contour, the point which is called as starting point is fixed. Then, the contour is scanned (is admissible - clockwise), and each vector of offset is noted by a complex number a+ib. Where a - point offset on x axis, and b - offset on y axis. Offset is noted concerning the previous point.

#### Introduce of the Original Project
>##### The General Algorithm of Recognition
>
> 1. Preliminary handling of the image - smoothing, a filtration of noise, a contrast raise
>2.	Binarization of the image and selection of contours of objects
>3.	Initial filtration of contours on perimeter, squares, to a crest factor, fractality and so on
>4.	Coercion of contours to uniform length, smoothing
>5.	Search of all discovered contours, searching of the template maximum similar to the given contour
>##### ContourAnalysis Library
>The library includes two projects. The first project <b> ContourAnalysis</b> - implements base functions of the contour analysis - creation of contours, a scalar product of contours, equalization, evaluation ICF and ACF, comparing and searching of templates.
>
> + The class <b>Contour</b> - creates and stores contours. It contains basic operations for contours - scalar product, scaling, equalization, normalization, a spectrum evaluation, evaluation ACF and ICF.
>+ The class <b>Template</b> is used for creation of base of templates. This class stores a contour, it ACF, descriptors ACF, the linear parameters of an initial contour (area), norm of a contour. Also, the template has a name which is used as the recognized value.
>+ Class <b>TemplateFinder</b> implements fast searching of a template for the given contour. Outcome of operation of this class is <b>FoundTemplateDesc</b> which contains an initial contour, and the template discovered for the given contour.
>+ Besides, <b>FoundTemplateDesc</b> contains similarity rate, angle of rotation and a scale of a contour, relative to a template.
>
> The second project - <b>ContourAnalysisProcessing</b> - contains methods for preliminary handling of the image, selection of contours, their filtrations and a recognition. Also, it contains tools for automatic generation of templates for recognition of printing symbols.
>
> Project <b>ContourAnalysisProcessing</b> uses library OpenCV (EmguCV .NET wrapper) for operation with the image.
>+ The class <b>ImageProcessor</b> is used for image handling. It, also, stores base of templates.
>+ - Method <b>ImageProcessor.ProcessImage()</b> receives the image on an input. Outcome of operation are lists discovered contours (<b>ImageProcessor.samples</b>) and the list of the recognized contours (<b>ImageProcessor.foundTemplates</b>).
>+ The class <b>ImageProcessor</b> contains also settings for searching of contours.
>The <b>ImageProcessor</b> works as follows:
>  1.	At first, the image will be transformed to gray-scale
>  2.	Then it is binarized by <b>AdaptiveThreshold</b>
>  3.	Contours are extracted
>  4.	Contours are filtered on linear parameters (length, square, etc.)
>  5. Contours are equalized, there is calculation ACF and ACF descriptors
>  6.	And then there is maximum suitable template
>
>+ The static class <b>TemplateGenerator</b> is used for automatic generation of templates of numerals of a certain font.
>
>Except two library projects, there is a demo-example showing operation of library with the webcam. The demo contains tools for creation and editing of templates, recognition tuning, and allows to produce recognition of contours from the webcam, and also allows to create the augmented reality.


#### My work
+ Translate to Chinese
+ Write the Form "tips" to introduce CA and how to use the program
+ Write the AboutBox.
