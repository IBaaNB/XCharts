

namespace XCharts.Editor
{
    [SerieEditor(typeof(Ring))]
    public class RingEditor : SerieEditor<Ring>
    {
        public override void OnCustomInspectorGUI()
        {
            PropertyTwoFiled("m_Center");
            PropertyTwoFiled("m_Radius");
            PropertyField("m_StartAngle");
            PropertyField("m_RingGap");
            PropertyField("m_RoundCap");
            PropertyField("m_Clockwise");

            PropertyField("m_TitleStyle");
            PropertyField("m_ItemStyle");
            PropertyField("m_Animation");
        }
    }
}