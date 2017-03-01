using UnityEngine;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples {

	public class startGame : MonoBehaviour {

		[SerializeField] private Material m_NormalMaterial;                
		[SerializeField] private Material m_OverMaterial;                  
		[SerializeField] private Material m_ClickedMaterial;               
		[SerializeField] private Material m_DoubleClickedMaterial;         
		[SerializeField] private VRInteractiveItem m_InteractiveItem;
		[SerializeField] private Renderer m_Renderer;

		public gameLoop startNew;

		void Start () {

		}


		private void Awake ()
		{
			m_Renderer.material = m_NormalMaterial;
		}

		private void OnEnable()
		{
			m_InteractiveItem.OnOver += HandleOver;
			m_InteractiveItem.OnOut += HandleOut;
			m_InteractiveItem.OnClick += HandleClick;
			m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
		}

		private void OnDisable()
		{
			m_InteractiveItem.OnOver -= HandleOver;
			m_InteractiveItem.OnOut -= HandleOut;
			m_InteractiveItem.OnClick -= HandleClick;
			m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
		}

		//Handle the Over event
		private void HandleOver()
		{
			m_Renderer.material = m_OverMaterial;
		}


		//Handle the Out event
		private void HandleOut()
		{
			m_Renderer.material = m_NormalMaterial;
		}

		//Handle the Click event
		public void HandleClick()
		{
			m_Renderer.material = m_ClickedMaterial;
			startNew.startGame();
		}
			

		//Handle the DoubleClick event
		private void HandleDoubleClick()
		{
			m_Renderer.material = m_DoubleClickedMaterial;
		}
	}
}