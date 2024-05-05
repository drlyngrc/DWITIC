from keras.models import load_model  # TensorFlow is required for Keras to work
from PIL import Image, ImageOps  # Install pillow instead of PIL
import numpy as np
import streamlit as st 


def waste_classify(img):
    # Disable scientific notation for clarity
    np.set_printoptions(suppress=True)

    # Load the model
    model = load_model("keras_model.h5", compile=False)

    # Load the labels
    class_names = open("labels.txt", "r").readlines()

    # Create the array of the right shape to feed into the keras model
    # The 'length' or number of images you can put into the array is
    # determined by the first position in the shape tuple, in this case 1
    data = np.ndarray(shape=(1, 224, 224, 3), dtype=np.float32)

    # Replace this with the path to your image
    image = img.convert("RGB")

    # resizing the image to be at least 224x224 and then cropping from the center
    size = (224, 224)
    image = ImageOps.fit(image, size, Image.Resampling.LANCZOS)

    # turn the image into a numpy array
    image_array = np.asarray(image)

    # Normalize the image
    normalized_image_array = (image_array.astype(np.float32) / 127.5) - 1

    # Load the image into the array
    data[0] = normalized_image_array

    # Predicts the model
    prediction = model.predict(data)
    index = np.argmax(prediction)
    class_name = class_names[index]
    confidence_score = prediction[0][index]

    # Print prediction and confidence score
    #print("Class:", class_name[2:], end="")
    #print("Confidence Score:", confidence_score)

    return class_name, confidence_score


st.set_page_config(layout='wide')

st.title("DWITIC : Digital Waste Identification Tool for Intelligent Categorization")

input_img = st.file_uploader("Enter your image", type=['jpeg', 'jpg', 'png'])

if input_img is not None:
    if st.button("Classify"):
        
        col1, col2, col3 = st.columns([1,1,1])

        with col1:
            st.info("Your uploaded Image")
            st.image(input_img, use_column_width=True)

        with col2:
            st.info("Your Result")
            image_file = Image.open(input_img)
            label, confidence_score = waste_classify(image_file)
            col4, col5 = st.columns([1,1])
            if label == "0 Leftover food\n":
                st.success("The image is classified as Leftover Food (Biodegradable).")
                with col4:
                    st.image("sdg goals/2.png", use_column_width=True)
                    st.image("sdg goals/12.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/13.png", use_column_width=True)
            elif label == "1 Fruit and vegetable peels\n":
                st.success("The image is classified as Fruit and Vegetable Peels (Biodegradable).")
                with col4:
                    st.image("sdg goals/11.png", use_column_width=True)
                    st.image("sdg goals/12.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/13.png", use_column_width=True)
            elif label == "2 Paper\n":
                st.success("The image is classified as Paper (Biodegradable).")
                with col4:
                    st.image("sdg goals/11.png", use_column_width=True)
                    st.image("sdg goals/12.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/13.png", use_column_width=True)
            elif label == "3 Single-use plastic\n":
                st.success("The image is classified as Single-use Plastic (Nonbiodegradable).")
                with col4:
                    st.image("sdg goals/11.png", use_column_width=True)
                    st.image("sdg goals/12.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/14.png", use_column_width=True)
            elif label == "4 Styrofoam\n":
                st.success("The image is classified as Styrofoam (Nonbiodegradable).")
                with col4:
                    st.image("sdg goals/11.png", use_column_width=True)
                    st.image("sdg goals/12.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/13.png", use_column_width=True)
            elif label == "5 Rubber\n":
                st.success("The image is classified as Rubber (Nonbiodegradable).")
                with col4:
                    st.image("sdg goals/11.png", use_column_width=True)
                    st.image("sdg goals/12.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/13.png", use_column_width=True)
            elif label == "6 Plastic bottle\n":
                st.success("The image is classified as Plastic Bottle (Recyclable).")
                with col4:
                    st.image("sdg goals/12.png", use_column_width=True)
                    st.image("sdg goals/14.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/15.png", use_column_width=True)
            elif label == "7 Glass\n":
                st.success("The image is classified as Glass (Recyclable).")
                with col4:
                    st.image("sdg goals/9.png", use_column_width=True)
                    st.image("sdg goals/11.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/12.png", use_column_width=True)
                    st.image("sdg goals/13.png", use_column_width=True)
            elif label == "8 Metal\n":
                st.success("The image is classified as Metal (Recyclable).")
                with col4:
                    st.image("sdg goals/9.png", use_column_width=True)
                    st.image("sdg goals/11.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/12.png", use_column_width=True)
                    st.image("sdg goals/13.png", use_column_width=True)
            elif label == "9 Used facemask\n":
                st.success("The image is classified as Used Facemask (Infectious).")
                with col4:
                    st.image("sdg goals/3.png", use_column_width=True)
                    st.image("sdg goals/11.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/12.png", use_column_width=True)
            elif label == "10 Used Syringe\n":
                st.success("The image is classified as Used Syringe (Infectious).")
                with col4:
                    st.image("sdg goals/3.png", use_column_width=True)
                    st.image("sdg goals/11.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/12.png", use_column_width=True)
            elif label == "11 Medical waste\n":
                st.success("The image is classified as Other Medical Waste (Infectious).")
                with col4:
                    st.image("sdg goals/3.png", use_column_width=True)
                    st.image("sdg goals/11.png", use_column_width=True)
                with col5:
                    st.image("sdg goals/12.png", use_column_width=True)
            else:
                st.error("The image is not classified as any relevant class.")

        with col3:
            st.info("Information")
            