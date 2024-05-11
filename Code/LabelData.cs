using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWITIC
{
    public class LabelInfo
    {
        public string Label { get; set; }
        public string Description { get; set; }
        public string Classification { get; set; }
        public string SDG { get; set; }
        public List<string> ImagePaths { get; set; }
    }

    internal static class LabelData
    {
        public static List<LabelInfo> Labels { get; private set; }

        static LabelData()
        {
            Labels = new List<LabelInfo>
            {
                new LabelInfo
                {
                    Label = "Fruit and Vegetable Peels",
                    Classification = "(Biodegradable)",
                    Description = "     Fruit and vegetable peel waste, often discarded despite containing valuable " +
                    "nutrients, contributes to organic waste accumulation and greenhouse gas emissions. " +
                    "To address this, individuals can compost peels for nutrient-rich soil, use them in cooking for " +
                    "flavor and nutrition, and preserve them for future use. Educating about their value and culinary " +
                    "uses promotes consumption and waste reduction. By composting, cooking with, and preserving fruit and " +
                    "vegetable peels, individuals and communities can contribute to reducing waste and fostering sustainable " +
                    "food consumption practices, mitigating environmental impacts.",
                    SDG = "Fruit and vegetable peels waste align primarily with SDGs related to, SDG 11, SDG 12, SDG 13.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Fruit and Vegetable Peels.png" }
                },
                new LabelInfo
                {
                    Label = "Glass",
                    Classification = "(Non-Biodegradable)",
                    Description = "     Glass waste, comprising discarded bottles, jars, and containers, " +
                    "poses environmental challenges such as wildlife hazards, visual pollution, and resource depletion " +
                    "from raw material mining. Energy-intensive production contributes to greenhouse gas emissions and " +
                    "climate change. Contamination occurs when glass waste mixes with other materials. " +
                    "Managing glass waste involves reducing consumption, reusing containers, and recycling " +
                    "through municipal programs. Supporting initiatives like bottle deposit systems and producer " +
                    "responsibility programs promotes recycling. Educating and advocating for sustainable packaging practices " +
                    "are crucial. Developing recycling infrastructure and incentivizing glass recycling through policy changes " +
                    "are essential for minimizing waste and fostering a circular economy.",
                    SDG = "Glass waste falls under several UN SDGs, including SDG 9, SDG 11, SDG 12, SDG 13.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Glass.png" }
                },
                new LabelInfo
                {
                    Label = "Leftover Foods",
                    Classification = "(Biodegradable)",
                    Description = "     Leftover food waste poses a global challenge, stemming from overproduction and " +
                    "consumer behavior, with adverse environmental, social, and economic impacts. Measures to address it " +
                    "include preventing overbuying through meal planning, donating surplus food, and composting organic waste. " +
                    "Encouraging portion control, proper storage, and raising awareness are vital. " +
                    "Advocacy for supportive policies can incentivize waste reduction efforts. Proactive steps at " +
                    "individual and policy levels, such as meal planning, donation, composting, and advocacy, collectively " +
                    "mitigate the impacts of food waste, promoting sustainable practices and resource conservation.",
                    SDG = "Leftover food falls under several SDGs, including SDG 2, SDG 12, SDG 13.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Leftover Foods.png" }
                },
                new LabelInfo
                {
                    Label = "Medical Waste",
                    Classification = "(Infectious)",
                    Description = "     Medical waste, encompassing items like surgical gloves and blood tubes, " +
                    "poses health and environmental risks if mishandled. Improper disposal can lead to infections, " +
                    "injuries, and pollution. Effective management is crucial to safeguard public health, " +
                    "protect the environment, and ensure healthcare worker safety. Key actions include source segregation, " +
                    "worker training, technology investment for treatment, regulatory compliance, waste minimization, " +
                    "exploring recycling, and public awareness campaigns. By adhering to these measures, healthcare facilities " +
                    "can mitigate risks, minimize environmental impact, and promote sustainable waste management practices, " +
                    "thus fostering a safer and cleaner healthcare environment.",
                    SDG = "Medical Wastes aligns with several SDG, specifically SDG 3, SDG 11, SDG 12.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Medical Waste.png" }
                },
                new LabelInfo
                {
                    Label = "Metal",
                    Classification = "(Recyclable)",
                    Description = "     Metal waste, originating from industrial, construction, and consumer sources, poses environmental hazards " +
                    "like soil and water contamination due to improper disposal. Both ferrous and non-ferrous metals contribute to habitat destruction, " +
                    "deforestation, and greenhouse gas emissions during extraction and processing. To manage this waste effectively, reducing consumption, " +
                    "reusing items, and recycling through local programs are essential. Supporting responsible manufacturing and disposal practices, " +
                    "along with raising awareness and advocating for sustainability, are crucial steps. By adopting these measures, individuals and " +
                    "communities can significantly reduce the environmental impact of metal waste, mitigating its contribution to climate change and " +
                    "environmental degradation.",
                    SDG = "Metal waste intersects with several SDGs, primarily focusing on SDG 9, SDG 11, SDG 12, SDG 13.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Metal.png" }
                },
                new LabelInfo
                {
                    Label = "Paper Products",
                    Classification = "(Biodegradable)",
                    Description = "     Paper waste, including newspapers and cardboard, forms a substantial part of " +
                    "municipal solid waste, leading to environmental concerns if improperly disposed. " +
                    "However, paper is highly recyclable, cutting resource usage and greenhouse gas emissions. " +
                    "Efficient waste management entails collection, sorting, and recycling, aided by curbside programs " +
                    "and sustainable practices. Initiatives like waste audits and awareness campaigns, alongside supportive " +
                    "policies, play a vital role. Addressing paper waste involves reducing consumption, recycling, " +
                    "composting, opting for sustainable sources, and advocating for policies favoring waste reduction. " +
                    "These efforts collectively minimize the environmental impact, fostering sustainable paper consumption " +
                    "and disposal practices.",
                    SDG = "Paper products waste aligns with several UN SDGs, primarily focusing on SDG 11, SDG 12, SDG 13.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Paper Products.png" }
                },
                new LabelInfo
                {
                    Label = "Plastic Bottles",
                    Classification = "(Recyclable)",
                    Description = "     Plastic bottle waste, originating from containers made of polyethylene terephthalate (PET) or " +
                    "high-density polyethylene (HDPE), poses a significant environmental challenge due to its durability and widespread use. " +
                    "Its production demands fossil fuels and emits greenhouse gases, contributing to climate change. " +
                    "Addressing this issue requires concerted efforts: reducing consumption through reusable alternatives, " +
                    "ensuring proper recycling adherence, advocating for policy changes like deposit systems and plastic bans, " +
                    "and fostering widespread awareness about the importance of reducing, reusing, and recycling plastic bottles. " +
                    "These actions can effectively mitigate the environmental impact of plastic bottle waste, combating climate change and " +
                    "promoting sustainable practices.",
                    SDG = "Plastic bottle waste intersects with several SDG goals, including SDG 12, SDG 14, SDG 15.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Plastic Bottles.png" }
                },
                new LabelInfo
                {
                    Label = "Rubber",
                    Classification = "(Non-Biodegradable)",
                    Description = "     Rubber waste, including discarded tires and industrial components, " +
                    "poses environmental risks through improper disposal methods like landfilling and burning, " +
                    "releasing harmful chemicals and greenhouse gases. Slow decomposition in landfills and " +
                    "space occupation exacerbate pollution. Despite recycling benefits, management is challenging due to " +
                    "bulk and composition diversity. Effective solutions involve promoting recycling and reuse initiatives, " +
                    "implementing regulations like extended producer responsibility schemes and landfill bans on whole tires, " +
                    "and educating the public about environmental impacts and eco-friendly alternatives. " +
                    "These measures encourage responsible waste management among manufacturers and consumers, ultimately reducing " +
                    "rubber waste and its adverse effects on the environment.",
                    SDG = "Rubber waste intersects with several SDGs, SDG 11, SDG 12, SDG 13.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Rubber.png" }
                },
                new LabelInfo
                {
                    Label = "Single-Use Plastic",
                    Classification = "(Non-Biodegradable)",
                    Description = "     Single-use plastics, such as bags and packaging, pose environmental threats due to " +
                    "their non-biodegradable nature and persistence, contaminating land and water and entering the food chain " +
                    "as microplastics. Unsustainable consumption and production patterns underlie their proliferation, " +
                    "demanding significant fossil fuel usage and causing pollution. To combat this, individuals can reduce " +
                    "consumption by opting for reusable alternatives, refuse single-use plastics to drive business change, " +
                    "and promote proper disposal and recycling. Supporting alternatives, implementing bans, improving recycling " +
                    "infrastructure, and raising awareness are crucial steps in effectively addressing single-use plastics waste " +
                    "and promoting environmental sustainability.",
                    SDG = "Single-use plastics waste align with several SDGs, primarily focusing on SDG 11, SDG 12, SDG 14.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Single-Use Plastic.png" }
                },
                new LabelInfo
                {
                    Label = "Styrofoam",
                    Classification = "(Non-Biodegradable)",
                    Description = "     Styrofoam, or expanded polystyrene (EPS), is a widely used plastic material in " +
                    "packaging and construction, posing environmental challenges due to its non-biodegradable nature and " +
                    "harmful manufacturing processes. Its production involves fossil fuels and emits greenhouse gases, " +
                    "while improper disposal releases methane in landfills. To address this, individuals can reduce consumption, " +
                    "opt for reusable or biodegradable alternatives, and advocate for policy changes banning " +
                    "single-use Styrofoam products. Reusing containers and supporting clean-up efforts also mitigate " +
                    "environmental harm. Educating others about sustainable practices further promotes environmental sustainability " +
                    "by minimizing Styrofoam waste and its impact on ecosystems.",
                    SDG = "Styrofoam waste implicates various SDGs, particularly SDG 11, SDG 12, SDG 13.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Styrofoam.png" }
                },
                new LabelInfo
                {
                    Label = "Used Facemask",
                    Classification = "(Infectious)",
                    Description = "     Used face mask waste, a byproduct of the COVID-19 pandemic, poses environmental " +
                    "and health risks due to non-biodegradable materials like polypropylene and potential pathogen transmission. " +
                    "Challenges in handling and disposal require proper protocols. Effective solutions involve promoting " +
                    "reusable masks, educating on proper disposal, organizing clean-up campaigns, establishing recycling programs, " +
                    "investing in research, enforcing regulations, raising public awareness, and engaging communities " +
                    "in collaborative efforts for sustainable waste management. These measures mitigate environmental pollution " +
                    "and health hazards associated with used mask waste, promoting a safer and cleaner environment amidst the pandemic.",
                    SDG = "Used face mask waste relates to several SDGs, SDG 3, SDG 11, SDG 12.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Used Facemask.png" }
                },
                new LabelInfo
                {
                    Label = "Used Syringe",
                    Classification = "(Infectious)",
                    Description = "     Used syringe waste presents significant health and environmental risks due " +
                    "to its potential to transmit blood-borne pathogens and cause needlestick injuries. " +
                    "Classified as infectious or biomedical waste, improper disposal can lead to contamination of soil " +
                    "and groundwater, posing hazards to waste handlers and the public. " +
                    "Addressing used syringe waste requires a multifaceted approach. Safe disposal practices, education, " +
                    "and training are crucial to minimize risks of needlestick injuries and environmental contamination. " +
                    "Community-based programs and government regulations ensure compliance and facilitate safe disposal.",
                    SDG = "Infectious waste aligns with several SDGs, primarily SDG 3, SDG 11, SDG 12.",
                    ImagePaths = new List<string> { @"C:\Users\glenn\OneDrive\Pictures\SDG\Used Syringe.png" }
                },
            };
        }
    }
}

